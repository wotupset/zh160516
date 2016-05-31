using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb =new StringBuilder();
            foreach(var di in DriveInfo.GetDrives())
            {
                sb.Append(di.Name);
                if (di.IsReady) {
                    sb.Append("\t剩餘空間" + di.AvailableFreeSpace);
                    sb.Append("\t總大小" + di.TotalSize);
                }
                sb.Append("\r\n");
            }
            textBox1.Text=sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string path = @"c:\";
            foreach (string di in Directory.GetFiles(path))
            {
                sb.Append(di);
                sb.Append("\r\n");
            }
            textBox1.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();
            string path = @"c:\";
            DirectoryInfo fii = new DirectoryInfo(path);
            MessageBox.Show("11");
            
            foreach (DirectoryInfo fi2 in fii.GetDirectories())
            {
                sb.Append("[D]" + fi2.Name);
                sb.Append("\t" + fi2.FullName);
                sb.Append("\r\n");
            }
            //FileInfo di = new FileInfo(path);
            foreach (FileInfo fi2 in fii.GetFiles())
            {
                sb.Append("[F]" + fi2.Name);
                sb.Append("\t" + fi2.Length);
                sb.Append("\r\n");
            }
            //
            textBox1.Text = sb.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //unicode編碼
            FileStream fs = new FileStream(@"C:\AMD\文章1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            StringBuilder sb = new StringBuilder();

            //string a = sr.ReadToEnd();
            //sb.Append(a);
            while (!sr.EndOfStream) {
                sb.Append(sr.ReadLine()).Append("\r\n");

            }

            textBox1.Text = sb.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ANSI編碼
            FileStream fs = new FileStream(@"C:\AMD\文章1.txt", FileMode.Open, FileAccess.Read);
            StringBuilder sb = new StringBuilder();

            int bb;
            while ((bb = fs.ReadByte()) != -1)
            {
                char c = (char)bb;
                sb.Append(c);
            }

            fs.Close();

            textBox1.Text = sb.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (EncodingInfo ei in Encoding.GetEncodings())
                sb.Append(ei.CodePage).Append("\t").Append(ei.DisplayName).Append("\r\n");

            textBox1.Text = sb.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(@"C:\AMD\文章1.txt", Encoding.GetEncoding(950));

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\AMD\wwwww.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.Write(textBox1.Text);
            sw.Flush();
            sw.Close();

            MessageBox.Show("儲存完畢！");
            
        }
    }
}

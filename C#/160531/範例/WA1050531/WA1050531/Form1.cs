using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA1050531
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var di in DriveInfo.GetDrives())
            {
                if (di.IsReady)
                {
                    sb.Append(di.Name).Append("\t磁碟種類：").Append(di.DriveType.ToString())
                            .Append("\t總大小：").Append(di.TotalSize)
                            .Append("\t總剩餘空間：").Append(di.TotalFreeSpace)
                            .Append("\t可用剩餘空間：").Append(di.AvailableFreeSpace)
                            .Append("\r\n");
                }
                else
                { 
                    sb.Append(di.Name).Append("\t磁碟種類：").Append(di.DriveType.ToString())
                        .Append("\r\n");
                }
            }

            textBox1.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path=@"C:\程式職訓班\C#_NET";
            StringBuilder sb = new StringBuilder();
            
            foreach (string a in Directory.GetDirectories(path))
                sb.Append(a).Append("\r\n");
            foreach (string a in Directory.GetFiles(path))
                sb.Append(a).Append("\r\n");

            textBox1.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string source=@"C:\程式職訓班\C#_NET\Car_GT.png";
            string target=@"C:\BB\Car_GT.png";

            if (File.Exists(@"C:\BB\Car_GT.png"))
            {
                DialogResult ans = MessageBox.Show("檔案已存在，是否要取代？", "詢問", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == System.Windows.Forms.DialogResult.Yes)
                {
                    File.Copy(source, target, true);
                    MessageBox.Show("檔案複製完成！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                File.Copy(source, target);
                MessageBox.Show("檔案複製完成！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            /*
            FileInfo fi = new FileInfo(@"C:\程式職訓班\C#_NET\Car_GT.png");
            fi.CopyTo(@"C:\BB\Car_GT.png");
            */

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            /*
            DirectoryInfo dii = new DirectoryInfo(@"C:\程式職訓班\C#_NET");            

            int folderCount=0, fileCount = 0;
            long totalSize = 0;

            foreach (DirectoryInfo di in dii.GetDirectories())
            {
                folderCount++;
                sb.Append(di.Name).Append("\r\n");
            }
            foreach (FileInfo fi in dii.GetFiles())
            {
                fileCount++;
                totalSize += fi.Length;
                sb.Append(fi.Name).Append("\t").Append(fi.Length).Append("\r\n");
            }
            sb.Append(string.Format("資料夾數：{0}\t檔案數：{1}\t總大小：{2}", folderCount, fileCount, totalSize));
            */

            MyFileInfo mfi = new MyFileInfo(@"C:\程式職訓班\C#_NET");
            sb.Append(string.Format("資料夾數：{0}\t檔案數：{1}\t總大小：{2}", mfi.FolderCount, mfi.FileCount, mfi.TotalSize));

            textBox1.Text = sb.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = myFact2(5).ToString();
        }

        private long myFact(int num)
        {
            long ans = 1;
            for (int i = 1; i <= num; i++)
                ans *= i;
            return ans;
        }

        private long myFact2(int num)
        {
            if (num == 1)
                return 1;
            else
                return num * myFact2(num - 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileStream source = new FileStream(@"C:\程式職訓班\SQLServer\SSDTBI_VS2012_x86_CHT.exe", FileMode.Open, FileAccess.Read);
            FileStream target = new FileStream(@"C:\BB\SSDTBI.exe", FileMode.Create, FileAccess.Write);

            /*  傳統 1Byte 1Byte 做
            int bb;
            while ((bb = source.ReadByte()) != -1)
            { 
                byte b=(byte)bb;
                target.WriteByte(b);
            }
            */

            //緩衝區寫法
            byte[] bbs = new byte[1024000];
            while (source.Read(bbs, 0, bbs.Length) > 0)
            {
                target.Write(bbs, 0, bbs.Length);
            }

            target.Flush();
            target.Close();
            source.Close();

            MessageBox.Show("複製完成！");

            //File.Copy(sorce, target);

        }


    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            label1.Text = BTN1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ans = "";
            //
            for (int i = 1; i <= 9; i++){
                //ans = ans + "i="+i + "\r\n";
                for (int j = 1; j <= 9; j++)
                {
                    //ans = ans + "j=" + j + "\r\n";
                    ans = ans+ i + "x" + j+"="+(i*j)+"\t";
                }
                //j = 0;                ans = ans + "j=" + j + "\r\n";
                ans = ans + "\r\n";
            }
                
            textBox1.Text = ans;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string ans = "";
            //
            StringBuilder ans = new StringBuilder();
            int iii=1234567890;
            double b = 66666.678;
            ans.Append(iii.ToString("C"));
            ans.Append("\r\n");
            ans.Append(b.ToString("####.00"));
            //
            textBox1.Text = ans.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string ans = "";
            StringBuilder ans = new StringBuilder();
            //
            int a3 = 1234567890;
            double c3 = 12345.6789;
            ans.Append("\r\n" + string.Format("{0}\r\n{0:#,###.00}\r\n{1}\r\n{1:00.00}", a3, c3));
            //ans = ans + "\r\n";
            ans.Append("\r\n" + string.Format("{0}\r\n{1}", a3.ToString("#,###.00"), c3));
            //ans = ans + "\r\n" + string.Format("{0}\r\n{1}", a3, c3);
            //
            textBox1.Text = ans.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("MessageBox.Show");
            DialogResult ans=MessageBox.Show("MessageBox.Show", "title", MessageBoxButtons.RetryCancel,MessageBoxIcon.Information);
            poi(ans.ToString());
            poi(ans.ToString(), "wwwwww");
            poi(qq:"2222");

            //
            //textBox1.Text = ans.ToString();

        }
        void poi(string text="aaa",string qq="ppp") {
            DialogResult ans = MessageBox.Show(text, qq, MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            //
            
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            int[] yy5={11,222,53,6};
            StringBuilder ans = new StringBuilder();
            ans.Append(fnc(1, 2, 3, 4)).Append("\r\n");
            ans.Append(fnc(yy5)).Append("\r\n");
            textBox1.Text = ans.ToString();

        }
        int fnc(params int[] xx)
        {
            int total = 0;
            foreach (int i in xx) {
                total = total + i;
            }
            return total;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a5 = 5, b5 = 6;
            fnc5(ref a5, ref b5);

            MessageBox.Show(a5.ToString(), b5.ToString());
        }
        int fnc5(ref int a5, ref int b5) 
        {
            a5 = a5 + 10;
            b5 = b5 + 10;

            return 1;
        }



    }
}

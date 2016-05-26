using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace WA1050524
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            //L1.Text = TB1.Text;

            sbyte b = 127;
            b = (sbyte)(b + 1);
            L1.Text = b.ToString();


            //int a = null;
            //Nullable<int> a = null;
            int? a = null;

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            int[] xx=new int[5];

            xx[0] = 90;
            xx[1] = 80;
            xx[2] = 70;
            xx[3] = 60;
            xx[4] = 50;
            
            string ans = "";
            /*
            ans += xx[0] + "\r\n";
            ans += xx[1] + "\r\n";
            ans += xx[2] + "\r\n";
            ans += xx[3] + "\r\n";
            ans += xx[4] + "\r\n";
            */
            /*
            for (int i = 0; i < xx.Length; i++)
                ans += xx[i] + "\r\n";
            */            
            foreach (int a in xx)
                ans += a + "\r\n";

                        
            double b = 12345.6789;
            DateTime dt1 = DateTime.Now;
            string c = "巨匠電腦";

            //ans += "B的值：" + b.ToString("#,###.00") + "\tC的值：" + c + "\t日期的值：" + dt1.ToString("F");
            ans += string.Format("B的值：{0:#,###.00}\r\nC的值：{1}\r\n日期的值：{2:D}\r\n再一次日期的值：{2:F}", b, c, dt1);

            TB2.Text = ans;

        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            string ans = "";
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    //ans += i + "*" + j + "=" + (i * j) + "\t";
                    ans += string.Format("{0}*{1}={2:00}  ", i, j, i * j);
                }
                ans += "\r\n";
            }
            TB2.Text = ans;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            /*
            string ans = "";
            for (int i = 1; i <= 100000; i++)
                ans = ans + i + ". 巨匠電腦\r\n";
            TB2.Text = ans;
            */

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 100000; i++)
                sb.Append(i).Append(". 巨匠電腦\r\n");
            TB2.Text = sb.ToString();
 
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            int a = 1234567890;
            double b = 12345.6789;
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = new DateTime(2016, 6, 9);
   
            StringBuilder sb = new StringBuilder();

            if (listBox1.SelectedIndex == -1)
            {
                sb.Append(a.ToString("c")).Append("\r\n");
                sb.Append(b.ToString("#,###.00")).Append("\r\n");
                sb.Append(dt1.ToString("D")).Append("\r\n");
                sb.Append(dt1.ToString("F")).Append("\r\n");
                sb.Append(dt1.ToString("yyyy-MMM-dd HH:mm:ss ddd")).Append("\r\n");
            }
            else
            {
                string s = listBox1.SelectedItem.ToString();
                string[] ss = s.Split('\t');
                CultureInfo cii = CultureInfo.GetCultureInfo(ss[0]);
                NumberFormatInfo nfi=cii.NumberFormat;
                sb.Append(nfi.CurrencySymbol).Append("\r\n");
                sb.Append(a.ToString("c",nfi)).Append("\r\n");

                DateTimeFormatInfo dtfi = cii.DateTimeFormat;
                sb.Append(dt1.ToString("D",dtfi)).Append("\r\n");
                sb.Append(dt1.ToString("d", dtfi)).Append("\r\n");
                sb.Append(dt1.ToString("F", dtfi)).Append("\r\n");
                sb.Append(dt1.ToString("f", dtfi)).Append("\r\n");
                foreach (string w in dtfi.DayNames)
                    sb.Append(w).Append("\r\n");
            }

            TB2.Text = sb.ToString();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                string item = ci.Name + "\t" + ci.DisplayName + "\t" + ci.NativeName;
                listBox1.Items.Add(item);
            }

        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("這是訊息方塊！");
            //MessageBox.Show("這是訊息方塊！","標題", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            DialogResult ans = MessageBox.Show("請做點選擇吧！？", "請選擇",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans == System.Windows.Forms.DialogResult.Yes)
                TB2.Text = "您按了是！";
            else if (ans == System.Windows.Forms.DialogResult.No)
                TB2.Text = "您選了否！";

        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            ShowMsg("內容1", "標題1");
            ShowMsg("內容2", "標題2");
            ShowMsg("內容3", "標題3");
        }

        /*
        void ShowMsg()
        {
            MessageBox.Show("這是訊息方塊！", "標題",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }        
        void ShowMsg(string text)
        {
            MessageBox.Show(text, "標題",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        */
        void ShowMsg(string text,string title)
        {
            MessageBox.Show(text, title,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WA1050526_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Image ii = Image.FromFile(@"C:\BB\Car_GT.png");
            label3.Image = ii;
            label3.AutoSize=false;
            label3.Width = ii.Width;
            label3.Height = ii.Height;
            label3.Text = "";            

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = string.Format("X：{0}，Y：{1}", e.X, e.Y);

            label3.Left = e.X;
            label3.Top = e.Y;

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            string a = "";
            switch (e.Button)
            { 
                case System.Windows.Forms.MouseButtons.Left:
                    a = "左鍵";break;
                case System.Windows.Forms.MouseButtons.Middle:
                    a = "中間鍵"; break;
                case System.Windows.Forms.MouseButtons.Right:
                    a = "右鍵"; break;
            }

            label2.Text = string.Format("按了 {2} 於 X：{0}，Y：{1}", e.X, e.Y, a);
            
        }
    }
}

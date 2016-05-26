using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WA1050526_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btns_Click(object sender, EventArgs e)
        {
            //Button bb = (Button)sender;
            Button bb = sender as Button;

            switch (bb.Text)
            {
                case "按1": label1.Text = "按鈕1被按了"; break;
                case "按2": label1.Text = "按鈕2被按了"; break;
                case "按3": label1.Text = "按鈕3被按了"; break;
            }
            
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Button bb = new Button();
            bb.Text = "新按鈕";
            /*
            bb.Left = 50;
            bb.Top = 200;
            */
            //bb.Location = new Point(50, 200);
            Random rr = new Random();            
            bb.Location = new Point(rr.Next(this.Width), rr.Next(this.Height));
            /*
            bb.Width = 100;
            bb.Height = 50;
            */
            bb.Size = new Size(100, 40);

            bb.Click += bb_Click;
            
            this.Controls.Add(bb);

        }

        void bb_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我是新按鈕，我被按了！");
        }
                
    }
}

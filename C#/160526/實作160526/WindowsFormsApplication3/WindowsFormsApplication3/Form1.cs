using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNS_Click(object sender, EventArgs e)
        {

            int xx=0;
            //
            Button bb = (Button)sender;

            label1.Text = bb.Text;
            //
            Button bbb = new Button();
            Random rr = new Random();
            bbb.Top = 100 + rr.Next(100);
            bbb.Left = 100+rr.Next(100);

            bbb.Width = 100;
            bbb.Height = 100;
            bbb.Click += bb_Click;
            this.Controls.Add(bbb);

        }
        void bb_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我是新按鈕，我被按了！");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            label1.Text = string.Format("{0},{1}", e.X, e.Y);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            label2.Text = string.Format("{0},{1},{2}", e.X, e.Y,e.Button);
        }




    }
}

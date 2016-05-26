using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb=new StringBuilder();
            //
            sb.Append("sb").Append("\r\n");
            //Zoo.Animal aa = new Zoo.Animal("www", "333");
            Zoo.Animal aa = new Zoo.Animal("名字""111");
            sb.Append(aa.F_Animal()).Append("\r\n");
            //
            textBox1.Text = sb.ToString();
        }


    }
}

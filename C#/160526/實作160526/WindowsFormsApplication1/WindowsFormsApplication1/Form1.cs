using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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
            //
            ClassLibrary1.Animal aa = new ClassLibrary1.Animal("類", "名", "色");
            sb.Append(aa.ToString()).Append("\r\n");

            textBox1.Text = sb.ToString();
        }

    }
}

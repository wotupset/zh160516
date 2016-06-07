using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WA1050607
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s=textBox1.Text;
            char c1=Convert.ToChar(s.Substring(0,1));
            bool ans = false;
            if (s.Length != 10)
            {
                if (c1 >= 'A' && c1 <= 'Z')
                {
                    if (s.Substring(1, 1) == "1" || s.Substring(1, 1) == "2")
                    {
                        int num;
                        if (int.TryParse(s.Substring(2), out num))
                        {
                            ans = true;
                        }
                    }
                }
            }

            if (ans)
                label1.Text = "正確";
            else
                label1.Text = "亂打";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[A-Z][12][0-9][0-9][0-9][0-9][0-9][0-9][0-9]$");
            Match ans = reg.Match(textBox1.Text);
            if (ans.Success)
                label1.Text = "正確";
            else
                label1.Text = "亂打";
        }
    }
}

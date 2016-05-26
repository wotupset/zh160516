using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zoo.Land;
using Zoo.Sea;
using Zoo.Air;

namespace WA1050526_1
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
                        
            
            Dog dd = new Dog("小黃", "黃");
            sb.Append(dd).Append(Feed(dd)).Append("\r\n");

            Dog[] dds = new Dog[2];
            dds[0] = new Dog("小黑", "黑");
            dds[1] = new Dog("小哈", "灰");
            foreach(Dog d in dds)
                sb.Append(d).Append(Feed(d)).Append("\r\n");

            Cat cc = new Cat("小咪","白");
            sb.Append(cc).Append(Feed(cc)).Append("\r\n");

            Lion ll = new Lion("小獅");
            sb.Append(ll.ToString()).Append(Feed(ll)).Append("\r\n");

            Shark ss = new Shark("小鯊","灰");
            sb.Append(ss.ToString()).Append(Feed(ss)).Append("\r\n");

            Dolphin do1 = new Dolphin("小豚", "灰");
            sb.Append(do1).Append(Feed(do1)).Append("\r\n");

            Eagle e1 = new Eagle("小鷹");
            sb.Append(e1).Append(Feed(e1)).Append("\r\n");

            Rooster r1 = new Rooster("小紅", "紅");
            sb.Append(r1).Append(Feed(r1)).Append("\r\n");

            Rooster r2 = new Rooster("小烏", "黑");
            sb.Append(r2).Append(Feed(r2)).Append("\r\n");
            

            /*
            //多型  
            Zoo.Animal aa;

            aa= new Dog("小黃", "黃");
            sb.Append(aa.ToString()).Append("\r\n");

            aa = new Cat("小咪", "白");
            sb.Append(aa.ToString()).Append("\r\n");

            aa = new Lion("小獅");
            sb.Append(aa.ToString()).Append("\r\n");

            aa = new Shark("小鯊", "灰");
            sb.Append(aa.ToString()).Append("\r\n");

            aa = new Dolphin("小豚", "灰");
            sb.Append(aa).Append("\r\n");

            aa = new Eagle("小鷹");
            sb.Append(aa).Append("\r\n");

            aa = new Rooster("小紅", "紅");
            sb.Append(aa).Append("\r\n");

            aa = new Rooster("小烏", "黑");
            Rooster rr = (Rooster)aa;
            sb.Append(aa).Append(rr.Fly()).Append("\r\n");
            */


            textBox1.Text = sb.ToString();

        }

        private string Feed(Zoo.Animal aa)
        {
            if(aa is Lion || aa is Eagle || aa is Shark)
                return "不可以餵食！會掛的！\r\n";
            else
                return "可以餵食！\r\n";
        }
        
    }
}

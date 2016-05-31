using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WA1050527
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            al.Add(100);
            al.Add(50.5);
            al.Add(100);
            al.Add("巨匠電腦");
            al.Add(200);
            al.Add(70.6);
            al.Add(200);
            al.Add("巨匠電腦");
            al.Add("Visual Studio .NET");
            al.Add(new Button());
            al.Add(30.4);
            al.Add(500);

            al.Remove("巨匠電腦");
            al.RemoveAt(5);

            StringBuilder sb = new StringBuilder();
            double total = 0;
            /*
            for (int i = 0; i < al.Count; i++)
            {
                sb.Append(al[i].ToString()).Append("\r\n");
            }
            */
            foreach (object oo in al)
            {
                sb.Append(oo.ToString()).Append("\r\n");

                
                int a;
                double b;
                if(int.TryParse(oo.ToString(),out a))
                    total+=a;
                else if (double.TryParse(oo.ToString(), out b))
                    total += b;
                
                /*
                try
                {
                    int a = int.Parse(oo.ToString());
                    total += a;
                }
                catch (Exception ex)
                {
                    try
                    {
                        double b = double.Parse(oo.ToString());
                        total += b;
                    }
                    catch (Exception ey)
                    { }
                }
                */
            }

            sb.Append(total);
            
            textBox1.Text = sb.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<double> al = new List<double>();
            al.Add(100);
            al.Add(50.5);
            al.Add(100);            
            al.Add(200);
            al.Add(70.6);
            al.Add(200);           
            al.Add(30.4);
            al.Add(500);
            
            StringBuilder sb = new StringBuilder();
            double total = 0;
            
            /*
            for (int i = 0; i < al.Count; i++)
            {
                sb.Append(al[i].ToString()).Append("\r\n");
                total+=al[i];
            }
            */
            foreach (double dd in al)
            {
                sb.Append(dd.ToString()).Append("\r\n");
                total += dd;
            }

            sb.Append(total);

            textBox1.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stack<int> st = new Stack<int>();
            st.Push(100);
            st.Push(200);
            st.Push(300);
            st.Push(100);
            st.Push(200);
            st.Push(400);
            st.Push(500);
            st.Push(200);

            StringBuilder sb = new StringBuilder();
            int total = 0;
            /*
            foreach (int dd in st)
            {
                sb.Append(dd.ToString()).Append("\t").Append(st.Count).Append("\r\n");
            }
            */

            while (st.Count > 0)
            {
                total += st.Peek();
                sb.Append(st.Pop().ToString()).Append("\t").Append(st.Count).Append("\r\n");
            }

            sb.Append(total);

            textBox1.Text = sb.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Queue<int> qq = new Queue<int>();
            qq.Enqueue(100);
            qq.Enqueue(200);
            qq.Enqueue(300);
            qq.Enqueue(100);
            qq.Enqueue(200);
            qq.Enqueue(400);
            qq.Enqueue(500);
            qq.Enqueue(200);

            StringBuilder sb = new StringBuilder();
            int total = 0;
            
            while (qq.Count > 0)
            {
                total += qq.Peek();
                sb.Append(qq.Dequeue().ToString()).Append("\t").Append(qq.Count).Append("\r\n");
            }

            sb.Append(total);

            textBox1.Text = sb.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HashSet<int> hs = new HashSet<int>();
            hs.Add(100);
            hs.Add(200);
            hs.Add(300);
            hs.Add(100);
            hs.Add(200);
            hs.Add(400);
            hs.Add(500);
            hs.Add(200);

            StringBuilder sb = new StringBuilder();
            int total = 0;

            foreach(int a in hs)
            {
                total+=a;
                sb.Append(a).Append("\r\n");
            }

            sb.Append(total);

            textBox1.Text = sb.ToString();



        }

        private void button6_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            HashSet<Dog> dhs = new HashSet<Dog>();

            Dog d1 = new Dog("小黃","黃",40);
            dhs.Add(d1);
            dhs.Add(new Dog("小黑", "黑", 20));
            dhs.Add(new Dog("小黃", "黃", 40));
            dhs.Add(new Dog("小黃", "黃", 40));

            foreach(Dog d in dhs)
                sb.Append(d).Append("\r\n");

            textBox1.Text = sb.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> scores = new Dictionary<string, int>();
            scores.Add("王小明", 80);
            scores.Add("李小英", 80);
            scores.Add("阿土伯", 60);
            scores.Add("錢夫人", 90);
            scores.Add("孫小美", 75);
            scores.Add("烏咪", 82);

            string a = "錢夫人";
            if (scores.ContainsKey(a))
                scores[a] = 95;
            else
                scores.Add(a, 95);

            StringBuilder sb = new StringBuilder();
            //sb.Append(scores["錢夫人"]).Append("\r\n");
            foreach(KeyValuePair<string,int> kv in scores)
                sb.Append(kv.Key).Append("\t").Append(kv.Value).Append("\r\n");
                        
            textBox1.Text = sb.ToString();

        }
    }
}

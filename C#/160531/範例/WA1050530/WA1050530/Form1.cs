using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;

namespace WA1050530
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart ts = new ThreadStart(() =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine(string.Format("{0}：{1}", Thread.CurrentThread.Name, i));
                    Thread.Sleep(200);
                }
            });
            
            Thread t1 = new Thread(ts);
            t1.Name = "執行緒1號";

            Thread t2 = new Thread(ts);
            t2.Name = "執行緒2號";

            Thread t3 = new Thread(ts);
            t3.Name = "執行緒3號";

            //t3.Priority = ThreadPriority.Highest;
            //t2.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start();
            t3.Start();



        }

        
        void MyThreadRun()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(string.Format("{0}：{1}", Thread.CurrentThread.Name, i));
                Thread.Sleep(200);                
            }
        }        


        private void button3_Click(object sender, EventArgs e)
        {
            long ans = 0;
            for (long i = 1; i <= 4000000000; i++)
                ans += i;
            label2.Text = ans.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) + 1).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            label2.Text = "計算處理中，請稍候...";

            ThreadStart ts = new ThreadStart(ThreadCalc);
            Thread tt = new Thread(ts);
            tt.Start();
            
        }

        private void ThreadCalc()
        {
            long ans = 0;
            for (long i = 1; i <= 4000000000; i++)
                ans += i;
            RealThreadCalcDone(ans);

            //MessageBox.Show(ans.ToString());
        }

        //宣告一個執行緒做完後要執行的委派方法
        delegate void ThreadCalcFinish(long answer);

        //實際完成一個方法(套用宣告委派的方法型態)
        void RealThreadCalcDone(long zz)
        {
            if (this.label2.InvokeRequired)
            {
                ThreadCalcFinish tcf = new ThreadCalcFinish(RealThreadCalcDone);
                this.Invoke(tcf, zz);
            }
            else
            {
                label2.Text = zz.ToString();
                button4.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*
            new Task(new Action(() => {
                for (int i = 1; i <= 100; i++)
                    Console.WriteLine(i);
            })).Start();
            */

            /*
            Task tt = new Task(() => MyThreadRun());
            tt.Start();
            */

            Task.Factory.StartNew(() =>
            {
                for (int i = 1; i <= 10; i++)
                    Console.WriteLine(i);
            }).ContinueWith(task =>
            {
                for (int i = 100; i <= 120; i++)
                    Console.WriteLine(i);
            }).ContinueWith(task =>
            {
                Console.WriteLine("工作完畢！");
            });

        }

        private async void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            label2.Text = "計算處理中，請稍候...";

            long ans = await Task.Run<long>(() =>
            {
                long rr = 0;
                for (long i = 1; i <= 4000000000; i++)
                    rr += i;
                return rr;
            });

            label2.Text = ans.ToString();
            button6.Enabled = true;

        }


    }
}

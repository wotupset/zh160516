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
        Graphics gg;
        public Form1()
        {
            InitializeComponent();
            gg = this.CreateGraphics();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Pen pp = new Pen(Color.FromArgb(38, 181, 70), 10);
            pp.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pp.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            pp.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            gg.DrawLine(pp, 50, 300, 50, 50);
            gg.DrawLine(pp, 50, 300, 300, 300);

            pp = new Pen(Color.Red, 10);
            pp.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor; 
            gg.DrawLines(pp, new Point[] {
                new Point(100,100),
                new Point(140,140),
                new Point(180,50),
                new Point(220,200)
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Brush bb;
            bb= new SolidBrush(Color.FromArgb(255, 255, 0));
            gg.FillRectangle(bb, 50, 50, 200, 150);
            bb = new SolidBrush(Color.FromArgb(255, 0, 0));
            gg.FillPie(bb, 50, 50, 200, 150, 0, 22);
            bb = new SolidBrush(Color.FromArgb(0,255, 0));
            gg.FillPie(bb, 50, 50, 200, 150, 22, 13);
            bb = new SolidBrush(Color.FromArgb(0, 0, 255));
            gg.FillPie(bb, 50, 50, 200, 150, 22+13, 30);
            bb = new SolidBrush(Color.FromArgb(0, 255, 255));
            gg.FillPie(bb, 50, 50, 200, 150, 22+13+30, 35);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Brush bb = new System.Drawing.Drawing2D.LinearGradientBrush(
                    new Point(50, 50),
                    new Point(350, 350),
                    Color.Red,
                    Color.Green
                );

            gg.FillRectangle(bb, 50, 50, 300, 300);

        }
    }
}

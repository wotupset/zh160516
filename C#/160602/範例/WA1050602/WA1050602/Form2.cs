using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA1050602
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            DialogResult ans=MessageBox.Show("是否離開？","結束", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == System.Windows.Forms.DialogResult.Yes)
            {
                //Application.Exit();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OFD1.Title = "選擇圖片";
            OFD1.Filter = "JPEG圖檔(*.jpg)|*.jpg|GIF圖檔(*.gif)|*.gif|PNG圖檔(*.png)|*.png|所有檔案(*.*)|*.*";
            DialogResult ans = OFD1.ShowDialog();
            if(ans== System.Windows.Forms.DialogResult.OK)
                textBox8.Text = OFD1.FileName;
        }

    }
}

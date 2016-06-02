using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("server=localhost;database=中文北風;UID=SQLAdmin;PWD=1234;"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO 產品資料(產品編號,產品,類別編號,供應商編號,單價,單位數量,庫存量,不再銷售,產品圖片) VALUES(@id,@name,@typeId,@storeId,@price,@unit,@stock,@sellOrNot,@pic)";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = textBox1.Text;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = textBox2.Text;
                    cmd.Parameters.Add("@typeId", SqlDbType.Int).Value = textBox4.Text;
                    cmd.Parameters.Add("@storeId", SqlDbType.Int).Value = textBox3.Text;
                    cmd.Parameters.Add("@price", SqlDbType.SmallMoney).Value = textBox6.Text;
                    cmd.Parameters.Add("@unit", SqlDbType.NVarChar).Value = textBox5.Text;
                    cmd.Parameters.Add("@stock", SqlDbType.Int).Value = textBox7.Text;
                    cmd.Parameters.Add("@sellOrNot", SqlDbType.Bit).Value = (radioButton1.Checked ? 0 : 1);
                    cmd.Parameters.Add("@pic", SqlDbType.Image);
                    if (textBox8.Text == null || textBox8.Text == "")
                        cmd.Parameters["@pic"].Value = DBNull.Value;
                    else
                    {
                        byte[] bb = System.IO.File.ReadAllBytes(textBox8.Text);
                        cmd.Parameters["@pic"].Value = bb;
                    }

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();

                    MessageBox.Show("產品資料新增成功！");

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;

                    textBox1.Focus();

                }
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("是否離開？", "結束", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == System.Windows.Forms.DialogResult.Yes)
            {
                //Application.Exit();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            OFD1.Title = "選擇圖片";
            OFD1.Filter = "JPEG圖檔(*.jpg)|*.jpg|GIF圖檔(*.gif)|*.gif|PNG圖檔(*.png)|*.png|所有檔案(*.*)|*.*";
            DialogResult ans = OFD1.ShowDialog();
            if(ans== System.Windows.Forms.DialogResult.OK)
                textBox8.Text = OFD1.FileName;
        }





    }
}

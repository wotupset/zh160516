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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tt = new DataTable();
            DataColumn c1 = new DataColumn("員工編號", Type.GetType("System.Int32"));
            tt.Columns.Add(c1);

            tt.Columns.Add(new DataColumn("姓名"));
            tt.Columns.Add("薪資", Type.GetType("System.Int32"));

            tt.Columns["薪資"].AllowDBNull = false;

            tt.PrimaryKey = new DataColumn[] { tt.Columns["員工編號"] };//tt.Columns[0]

            dataGridView1.DataSource = tt;
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString());
            DataTable tt = dataGridView1.DataSource as DataTable;

            if (e.Exception is FormatException)
            {
                string nn = tt.Columns[e.ColumnIndex].ColumnName;
                MessageBox.Show(nn + " 請輸入正確的數值！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.Exception is NoNullAllowedException)
            {
                MessageBox.Show("請輸入必須填寫的欄位！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.Exception is ConstraintException)
            {
                MessageBox.Show("欄位！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                MessageBox.Show("發生錯誤！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            DataTable tt = dataGridView1.DataSource as DataTable;
            DataRow row;
            //
            row = tt.NewRow();
            row[0] = 1;
            row[1] = "aa";
            row[2] = 11;
            tt.Rows.Add(row);
            //
            row = tt.NewRow();
            row[0] = 2;
            row[1] = "ww";
            row[2] = 22;
            tt.Rows.Add(row);
            //
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("server=localhost;database=中文北風;UID=SQLUser;PWD=1234;"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT 產品編號,產品,單價,單位數量,庫存量 FROM 產品資料", conn))
                {
                    conn.Open();
                    SqlDataReader mydr = cmd.ExecuteReader();

                    DataTable tt = new DataTable();
                    for (int i = 0; i < mydr.FieldCount; i++)
                        tt.Columns.Add(mydr.GetName(i), mydr.GetFieldType(i));

                    DataRow rr;
                    while (mydr.Read())
                    {
                        rr = tt.NewRow();
                        for (int i = 0; i < mydr.FieldCount; i++)
                            rr[i] = mydr[i];
                        tt.Rows.Add(rr);
                    }
                    mydr.Close();
                    cmd.Dispose();
                    conn.Close();

                    dataGridView1.DataSource = tt;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable tt = dataGridView1.DataSource as DataTable;

            int rr = e.RowIndex;
            int cc = e.ColumnIndex;
            int id = (int)dataGridView1.Rows[rr].Cells[0].Value; 
            //MessageBox.Show(rr + "," + cc + "," + id, "www");
            byte[] bb ;

            using (SqlConnection conn = new SqlConnection("server=localhost;database=中文北風;UID=SQLUser;PWD=1234;"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT 產品圖片 FROM 產品資料 WHERE 產品編號=" + id;

                    conn.Open();
                    //byte[] bb = cmd.ExecuteScalar() as byte[];
                    bb = cmd.ExecuteScalar() as byte[];
                    cmd.Dispose();//Dispose() 釋放資源
                    conn.Close();//Close() 關閉連結

                }

            }
            System.IO.MemoryStream ms = new System.IO.MemoryStream(bb);
            System.Drawing.Bitmap bmp = new Bitmap(ms);
            PicLabel.AutoSize = false;
            PicLabel.Width = bmp.Width;
            PicLabel.Height = bmp.Height;
            PicLabel.Text = "";
            PicLabel.Image = bmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("server=localhost;database=中文北風;UID=SQLAdmin;PWD=1234;"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    //cmd.CommandText = "SELECT 產品編號,產品,單價,單位數量,庫存量 FROM 產品資料 WHERE 單價>=" + textBox1.Text + " AND 單價<=" + textBox2.Text;
                    cmd.CommandText = "SELECT 產品編號,產品,單價,單位數量,庫存量 FROM 產品資料 WHERE 單價>=@price1 AND 單價<=@price2";
                    cmd.Parameters.Add("@price1", SqlDbType.SmallMoney).Value = textBox1.Text;
                    cmd.Parameters.Add("@price2", SqlDbType.SmallMoney).Value = textBox2.Text;


                        conn.Open();
                            SqlDataReader mydr = cmd.ExecuteReader();
                            DataTable tt = new DataTable();
                            tt.Load(mydr);
                            mydr.Close();
                            cmd.Dispose();
                        conn.Close();

                    dataGridView2.DataSource = tt;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2;//第二個表單
            foreach (Form f in Application.OpenForms)//表單型別
            {
                if (f.Text == "Form2")//列出OpenForms的text
                {
                    f2 = (Form2)f;//若OpenForms有相同標題 就取代Form2
                    f2.Activate();//並取得焦點
                    return;
                }
            }

            f2= new Form2();
            f2.Show();
        }




    }
}
//
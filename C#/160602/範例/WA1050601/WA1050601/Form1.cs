using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA1050601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\程式職訓班\C#_NET\資料庫檔\北風.mdb";

            try
            {
                conn.Open();
                MessageBox.Show("連接 Access 北風 成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("連接 Access 北風 失敗！");
            }
            finally
            {
                conn.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\程式職訓班\C#_NET\資料庫檔\資料.xls;";
            conn.ConnectionString += "Extended Properties=\"EXCEL 8.0;HDR=YES\"";

            try
            {
                conn.Open();
                MessageBox.Show("連接 Excel 資料 成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("連接 Excel 資料 失敗！");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OdbcConnection conn = new OdbcConnection();
            conn.ConnectionString = @"Driver={Microsoft Access Driver (*.mdb)};Dbq=C:\程式職訓班\C#_NET\資料庫檔\北風.mdb";

            try
            {
                conn.Open();
                MessageBox.Show("ODBC 連接 Access 北風 成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("ODBC 連接 Access 北風 失敗！");
            }
            finally
            {
                conn.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OdbcConnection conn = new OdbcConnection();
            conn.ConnectionString = @"Driver={Microsoft Excel Driver (*.xls)};DBQ=C:\程式職訓班\C#_NET\資料庫檔\資料.xls;";            

            try
            {
                conn.Open();
                MessageBox.Show("ODBC 連接 Excel 資料 成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("ODBC 連接 Excel 資料 失敗！");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OdbcConnection conn = new OdbcConnection();
            conn.ConnectionString = @"DSN=MyDsn;";

            try
            {
                conn.Open();
                MessageBox.Show("ODBC 連接 MyDsn 成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("ODBC 連接 MyDsn 失敗！");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=localhost;database=中文北風;Integrated Security=SSPI";            

            try
            {
                conn.Open();
                MessageBox.Show("Window驗證 連接 SQLServer 北風 成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Window驗證 連接 SQLServer 北風 失敗！");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=localhost;database=中文北風;UID=Mickey;PWD=1234";

            try
            {
                conn.Open();
                MessageBox.Show("SQL驗證 連接 SQLServer 北風 成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("SQL驗證 連接 SQLServer 北風 失敗！");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=localhost;database=中文北風;UID=SQLAdmin;PWD=1234");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //cmd.CommandText = "CREATE TABLE 員員表(編號 INT,姓名 NCHAR(5),到職日 DATE,薪資 INT)";
            cmd.CommandText = "DROP TABLE 員員表";
            
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("建立員員表 成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("建立員員表 失敗！");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("server=localhost;database=中文北風;UID=SQLUser;PWD=1234"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT 產品編號,產品,單價,單位數量,庫存量 FROM 產品資料", conn))
                {                    
                    conn.Open();
                    SqlDataReader mydr = cmd.ExecuteReader();
                    if (mydr.HasRows)
                    {
                        StringBuilder sb = new StringBuilder();

                        //欄名
                        for (int i = 0; i < mydr.FieldCount; i++)
                            sb.Append(mydr.GetName(i)).Append("\t");
                        sb.Append("\r\n");
                        //資料
                        while (mydr.Read())
                        {
                            for (int i = 0; i < mydr.FieldCount; i++)
                                sb.Append(mydr[i].ToString()).Append("\t");
                            sb.Append("\r\n");
                        }
                        mydr.Close();
                        textBox1.Text = sb.ToString();
                    }
                    else
                    {
                        MessageBox.Show("查無任何產品資料！");
                    }
                    
                    cmd.Dispose();
                    conn.Close();                    
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection())
            {                
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\程式職訓班\C#_NET\資料庫檔\資料.xls;";
                conn.ConnectionString += "Extended Properties=\"EXCEL 8.0;HDR=YES\"";
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT 產品編號,品名,價錢 FROM [Sheet1$]";

                    conn.Open();
                    OleDbDataReader mydr = cmd.ExecuteReader();
                    StringBuilder sb = new StringBuilder();
                    //欄名
                    for (int i = 0; i < mydr.FieldCount; i++)
                        sb.Append(mydr.GetName(i)).Append("\t");
                    sb.Append("\r\n");
                    //資料
                    while (mydr.Read())
                    {
                        for (int i = 0; i < mydr.FieldCount; i++)
                            sb.Append(mydr[i].ToString()).Append("\t");
                        sb.Append("\r\n");
                    }
                    mydr.Close();
                    textBox1.Text = sb.ToString();

                    cmd.Dispose();
                    conn.Close();
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection())
            {
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\程式職訓班\C#_NET\資料庫檔\資料.xls;";
                conn.ConnectionString += "Extended Properties=\"EXCEL 8.0;HDR=YES\"";
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO [Sheet1$](產品編號,品名,價錢) VALUES(26,'巧克力',50) ";

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();

                    MessageBox.Show("資料新增成功！");
                }
            }
        }
    }
}

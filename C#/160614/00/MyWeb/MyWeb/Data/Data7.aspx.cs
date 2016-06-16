using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWeb.Data
{
    public partial class Data7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nn=Request.QueryString["cn"];

            SqlConnection cnn = new SqlConnection("server=localhost;database=中文北風;UID=SQLUser;PWD=1234;");
            SqlCommand cmd = new SqlCommand("WAITFOR DELAY '00:00:10' SELECT 客戶編號,公司名稱,連絡人,連絡人職稱,電話,地址 FROM 客戶 WHERE 公司名稱 LIKE ('%'+@cname+'%')", cnn);
            cmd.Parameters.Add("@cname", SqlDbType.NVarChar).Value = nn;

            cnn.Open();
            SqlDataReader mydr = cmd.ExecuteReader();
            DataTable tt = new DataTable();
            tt.Load(mydr);
            mydr.Close();
            cmd.Dispose();
            cnn.Close();

            GridView1.DataSource = tt;
            GridView1.DataBind();       //實際將資料與GridView結合

        }
    }
}
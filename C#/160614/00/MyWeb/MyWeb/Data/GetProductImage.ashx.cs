using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace MyWeb.Data
{
    /// <summary>
    /// GetProductImage 的摘要描述
    /// </summary>
    public class GetProductImage : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            int pid = int.Parse(context.Request.QueryString["pid"]);

            SqlConnection cnn = new SqlConnection("server=localhost;database=中文北風;UID=SQLUser;PWD=1234");
            SqlCommand cmd = new SqlCommand("SELECT 產品圖片 FROM 產品資料 WHERE 產品編號=@pid", cnn);
            cmd.Parameters.Add("@pid", SqlDbType.Int).Value = pid;
            cnn.Open();
            byte[] pp = cmd.ExecuteScalar() as byte[];
            cmd.Dispose();
            cnn.Close();
            
            context.Response.OutputStream.Write(pp, 0, pp.Length);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
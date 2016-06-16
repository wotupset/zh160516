using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Mvc;

namespace MyMvcWeb.Controllers
{
    public class ToolController : Controller
    {
        //
        // GET: /Tool/


        public ActionResult GetProductImage(int? pid)
        {
            byte[] pp = new byte[0];

            SqlConnection cnn = new SqlConnection("server=localhost;database=中文北風;UID=SQLUser;PWD=1234");
            SqlCommand cmd = new SqlCommand("SELECT 產品圖片 FROM 產品資料 WHERE 產品編號=@pid", cnn);
            cmd.Parameters.Add("@pid", SqlDbType.Int).Value = pid;
            cnn.Open();
            object oo = cmd.ExecuteScalar();
            if (oo != DBNull.Value) pp = (byte[])oo;
            cmd.Dispose();
            cnn.Close();

            return File(pp, "image/gif");
        }

        public ActionResult DownloadWordFile()
        {
            string path = Server.MapPath("/PP/Word文件.doc");
            return File(path, "application/msword","我的文件.doc");
        }
        public FilePathResult DownloadWordFile2()
        {
            string path = Server.MapPath("/PP/Word文件.docx");
            return File(path, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "我的文件.docx");
        }

    }
}

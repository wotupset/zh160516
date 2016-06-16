using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MyMvcWeb.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            string path = Server.MapPath("/App_Data/VisitCount.txt");

            string nn = System.IO.File.ReadAllText(path);
            nn = (int.Parse(nn) + 1).ToString();

            System.IO.File.WriteAllText(path, nn);

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 8 - nn.Length; i++)
                sb.Append("<img src='/images/num2/0.gif' />");
            for (int i = 0; i < nn.Length; i++)
                sb.Append(string.Format("<img src='/images/num2/{0}.gif' />", nn.Substring(i, 1)));

            ViewData["VisitCount"] = sb.ToString();


            string bgPath=Server.MapPath("/images/BG");
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(bgPath);
            System.IO.FileInfo[] files = di.GetFiles();
            Random rr = new Random();
            ViewData["BG"] = files[rr.Next(files.Length)].Name;

            return View();
        }


        public ActionResult Page2()
        {
            int aa = 100;
            aa += 150;

            ViewData["V1"] = aa;
            ViewData["V2"] = "巨匠電腦";

            StringBuilder sb = new StringBuilder();
            sb.Append("<table border='1'>");
            for (int i = 1; i <= 9; i++)
            {
                sb.Append("<tr>");
                for (int j = 1; j <= 9; j++)
                {
                    sb.Append(string.Format("<td style='text-align:center;'>{0}*{1}={2}</td>", i, j, i * j));
                }
                sb.Append("</tr>");
            }
            sb.Append("</table>");

            ViewData["V3"] = sb.ToString();

            return View();
        }

        public ActionResult Page3()
        {
            int aa = 100;
            aa += 250;
            ViewData["VV1"] = aa;
            ViewData["VV2"] = "巨匠電腦";

            StringBuilder sb = new StringBuilder();
            sb.Append("<table border='1'>");
            for (int i = 1; i <= 9; i++)
            {
                sb.Append("<tr>");
                for (int j = 1; j <= 9; j++)
                {
                    sb.Append(string.Format("<td style='text-align:center;'>{0}*{1}={2}</td>", i, j, i * j));
                }
                sb.Append("</tr>");
            }
            sb.Append("</table>");

            ViewData["VV3"] = sb.ToString();

            ViewData["VV4"] = "<img src='/images/Pic1.jpg' />";
            //ViewData["VV5"] = Server.HtmlEncode("<script>alert('被駭囉！哇哈哈！');document.location='http://tw.yahoo.com';</script>");
            ViewData["VV5"] = "<script>alert('被駭囉！哇哈哈！');document.location='http://tw.yahoo.com';</script>";

            return View();
        }

        public ActionResult Page4()
        {
            ViewData["PageName"] = "頁面4";
            int aa = 100;
            aa += 250;
            ViewData["VV1"] = aa;
            ViewData["VV2"] = "巨匠電腦";

            StringBuilder sb = new StringBuilder();
            sb.Append("<table border='1'>");
            for (int i = 1; i <= 9; i++)
            {
                sb.Append("<tr>");
                for (int j = 1; j <= 9; j++)
                {
                    sb.Append(string.Format("<td style='text-align:center;'>{0}*{1}={2}</td>", i, j, i * j));
                }
                sb.Append("</tr>");
            }
            sb.Append("</table>");

            ViewData["VV3"] = sb.ToString();

            ViewData["VV4"] = "<img src='/images/Pic1.jpg' />";
            ViewData["VV5"] = "<script>alert('被駭囉！哇哈哈！');</script>";

            return View("PP");
        }

        public ActionResult Page5()
        {
            ViewData["PageName"] = "頁面5";
            int aa = 1200;
            aa += 250;
            ViewData["VV1"] = aa;
            ViewData["VV2"] = "桃園認證中心";

            ViewData["VV4"] = "<img src='/images/rooms/room20.jpg' />";            

            return View("PP");
        }
    }
}

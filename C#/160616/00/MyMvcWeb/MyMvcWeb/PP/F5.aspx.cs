using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWeb
{
    public partial class F5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int n1;

            if (Application["MyApp"] == null)
                n1 = 1;
            else            
                n1 = (int)Application["MyApp"];

            n1 = n1 + 1;
            Application["MyApp"] = n1;

            //Application.Add(Key,Value)
            //Application.Remove(Key)

            Label1.Text = n1.ToString();



            int n2;

            if (Session["MySess"] == null)
                n2 = 10;
            else
                n2 = (int)Session["MySess"];

            n2 = n2 + 10;
            Session["MySess"] = n2;

            //Session.Add(Key,Value)
            //Session.Remove(Key)

            Label2.Text = n2.ToString();



            HttpCookie cc;
            cc = Request.Cookies["MyC"];
            if (cc == null)
                Label3.Text = "第一次光臨本站！";
            else            
                Label3.Text = cc.Value;
            
            
            HttpCookie newCC = new HttpCookie("MyC");
            newCC.Expires = new DateTime(9999, 12, 31);
            newCC.Value = DateTime.Now.ToString();
            Response.Cookies.Add(newCC);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label5.Text = Literal1.Text = "巨匠電腦";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s = "<img src='/images/Pic1.jpg' />";
            Label5.Text = Literal1.Text = s;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
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

            Label5.Text = Literal1.Text = sb.ToString();
        }
    }
}
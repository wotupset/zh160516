using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Text;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (1 == 1) {//計數器
                string path = Server.MapPath("./App_Data/TextFile1.txt");
                string nn = System.IO.File.ReadAllText(path);
                nn = (int.Parse(nn) + 1).ToString();
                System.IO.File.WriteAllText(path, nn);
                StringBuilder sb = new StringBuilder();
                sb.Append(nn);
                Literal1.Text = sb.ToString();
            }

            if (1 == 1) {//cookie
                HttpCookie cc;
                cc = Request.Cookies["MyC"];
                if (cc == null)
                    Label3.Text = "第一次光臨本站！";
                else
                    Label3.Text = cc.Value;

                HttpCookie newCC = new HttpCookie("MyC");
                newCC.Value = DateTime.Now.ToString();
                Response.Cookies.Add(newCC);
            }

            if (1 == 1) {//session
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
            }

            if (1 == 1) {//app
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
            }


        }
    }
}
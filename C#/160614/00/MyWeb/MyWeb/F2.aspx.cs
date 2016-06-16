using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWeb
{
    public partial class F2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*  get
            Label2.Text = Request.QueryString["Account"];
            Label3.Text = Request.QueryString["Password"];
            Label4.Text = Request.QueryString["ID"];
            Label5.Text = Request.QueryString["Birth"];
            Label6.Text = Request.QueryString["EMail"];            
            */

            //  post
            Label2.Text = Request.Form["Account"];
            Label3.Text = Request.Form["Password"];
            Label4.Text = Request.Form["ID"];
            Label5.Text = Request.Form["Birth"];
            Label6.Text = Request.Form["EMail"];            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWeb
{
    public partial class F4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {    
            /*
            Label1.Text = Request.QueryString["Account"];
            Label2.Text = Request.QueryString["Password"];
            Label3.Text = Request.QueryString["ID"];
            Label4.Text = Request.QueryString["Birth"];
            Label5.Text = Request.QueryString["Sex"];            
            Label6.Text = Request.QueryString["Edu"];
            Label7.Text = Request.QueryString["EMail"];
            */


            TextBox tb;
            RadioButtonList rbl;
            DropDownList ddl;
            Calendar cc;

            tb = PreviousPage.FindControl("TextBox1") as TextBox;
            Label1.Text = tb.Text;

            tb = PreviousPage.FindControl("TextBox2") as TextBox;
            Label2.Text = tb.Text;

            tb = PreviousPage.FindControl("TextBox3") as TextBox;
            Label3.Text = tb.Text;

            cc = PreviousPage.FindControl("Calendar1") as Calendar;
            Label4.Text = cc.SelectedDate.ToString();

            rbl = PreviousPage.FindControl("RadioButtonList1") as RadioButtonList;
            Label5.Text = rbl.SelectedValue;

            ddl = PreviousPage.FindControl("DropDownList1") as DropDownList;
            Label6.Text = ddl.SelectedValue;

            tb = PreviousPage.FindControl("TextBox4") as TextBox;
            Label7.Text = tb.Text;



        }
    }
}
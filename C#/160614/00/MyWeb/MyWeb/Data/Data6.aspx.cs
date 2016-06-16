using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWeb.Data
{
    public partial class Data6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int nn;
            if (!int.TryParse(Request.QueryString["pid"], out nn))
            {
                DetailsView1.DefaultMode = DetailsViewMode.Insert;
            }



        }
    }
}
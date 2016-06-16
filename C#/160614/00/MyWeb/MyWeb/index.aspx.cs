using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWeb
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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

            Literal1.Text = sb.ToString();

        }
    }
}
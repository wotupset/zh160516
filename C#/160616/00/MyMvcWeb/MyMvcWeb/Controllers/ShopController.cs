using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MyMvcWeb.Controllers
{
    public class ShopController : Controller
    {
        //
        // GET: /Shop/

        public ActionResult Main(int? p)
        {
            int currentPage = 1;
            if (p != null)
                currentPage = p.Value;


            List<Models.ProductItem> result = null;

            SqlConnection cnn = new SqlConnection("server=localhost;database=中文北風;UID=SQLUser;PWD=1234;");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "產品分頁瀏覽";
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@page", SqlDbType.Int).Value = currentPage;
            cmd.Parameters.Add("@total", SqlDbType.Int);
            cmd.Parameters["@page"].Direction = ParameterDirection.Input;
            cmd.Parameters["@total"].Direction = ParameterDirection.Output;

            cnn.Open();
            SqlDataReader mydr = cmd.ExecuteReader();
            if (mydr.HasRows)
            {
                result = new List<Models.ProductItem>();
                while (mydr.Read())
                {
                    Models.ProductItem ii = new Models.ProductItem();
                    ii.Id = Convert.ToInt32(mydr["產品編號"]);
                    ii.Name = Convert.ToString(mydr["產品"]);
                    ii.StoreId = Convert.ToInt32(mydr["供應商編號"]);
                    ii.StoreName = Convert.ToString(mydr["供應商"]);
                    ii.TypeId = Convert.ToInt32(mydr["類別編號"]);
                    ii.TypeName = Convert.ToString(mydr["類別名稱"]);
                    ii.Price = Convert.ToDouble(mydr["單價"]);
                    ii.Unit = Convert.ToString(mydr["單位數量"]);
                    ii.Stock = Convert.ToInt32(mydr["庫存量"]);
                    result.Add(ii);
                }
            }
            mydr.Close();

            int total = (int)cmd.Parameters["@total"].Value;

            cmd.Dispose();
            cnn.Close();

            //產生頁面連結
            int totalPage = (int)Math.Ceiling(total / 10.0);
            StringBuilder sb=new StringBuilder();
            for (int i = 1; i <= totalPage; i++)
            {
                if (i == currentPage)
                    sb.Append(i + "&nbsp;&nbsp;");
                else
                    sb.Append(string.Format("<a href=/MyShop?p={0}>{0}</a>&nbsp;&nbsp;", i));
            }
            ViewData["PageLink"] = sb.ToString();

            return View(result);

        }

        
        public ActionResult AddToCart(int? pid)
        {
            if (pid == null)
                return RedirectToAction("Main");

            //新建立購物車或取出用戶的原有購物車
            HashSet<Models.CartItem> myCart=null;
            if (Session["MyCart"] == null)
                myCart = new HashSet<Models.CartItem>();
            else
                myCart = Session["MyCart"] as HashSet<Models.CartItem>;
            

            //查出該項產品的資料
            SqlConnection cnn = new SqlConnection("server=localhost;database=中文北風;UID=SQLUser;PWD=1234");
            SqlCommand cmd = new SqlCommand("SELECT 產品編號,產品,單價,庫存量 FROM 產品資料 WHERE 產品編號=@pid", cnn);
            cmd.Parameters.Add("@pid", SqlDbType.Int).Value = pid.Value;
            cnn.Open();

            SqlDataReader mydr = cmd.ExecuteReader();
            mydr.Read();

            Models.CartItem ci = new Models.CartItem();
            ci.Id = Convert.ToInt32(mydr["產品編號"]);
            ci.Name = Convert.ToString(mydr["產品"]);            
            ci.Price = Convert.ToDouble(mydr["單價"]);            
            ci.Stock = Convert.ToInt32(mydr["庫存量"]);
            ci.Quantity = 1;

            mydr.Close();
            cmd.Dispose();
            cnn.Close();

            //將產品加入購物車
            myCart.Add(ci);
            Session["MyCart"] = myCart; //回存購物車至Session中

            //前往購物車頁面
            return RedirectToAction("MyShoppingCart");
        }

        public ActionResult MyShoppingCart()
        {
            if (Session["MyCart"] == null)
                return RedirectToAction("Main");

            HashSet<Models.CartItem> myCart = (HashSet<Models.CartItem>)Session["MyCart"];

            return View(myCart);
        }

        public ActionResult ClearCart()
        {
            Session["MyCart"] = null;
            Session.Remove("MyCart");
            return RedirectToAction("Main");
        }



    }
}

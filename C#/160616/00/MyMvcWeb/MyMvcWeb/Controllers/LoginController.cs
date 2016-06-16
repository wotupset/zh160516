using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcWeb.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Main()
        {
            return View();
        }

        //public ActionResult LoginDone(string Account,string Password)
        public ActionResult LoginDone(Models.LoginInfo info)
        {
            /*
            string aa = Request.QueryString["Account"];
            string pp = Request.QueryString["Password"];
            
            string aa = Request.Form["Account"];
            string pp = Request.Form["Password"];
            */
            
            /*
            ViewData["aa"] = info.Account;
            ViewData["bb"] = info.Password;
            */

            return View(info);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcWeb.Controllers
{
    public class loginController : Controller
    {
        //
        // GET: /login/
        public ActionResult index() { return View(); }

        public ActionResult page2() {//string name
            //string name = Request.QueryString["name"];
            string name = Request.Form["name"];
            ViewData["v1"] = name;//

            return View(); }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcWeb.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index() {
            int aa = 100;
            aa += 150;
            ViewData["v1"]=aa;//

            
            return View(); }
        public ActionResult page2() { return View(); }

    }
}

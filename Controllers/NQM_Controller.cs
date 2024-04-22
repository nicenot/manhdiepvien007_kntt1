using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace manh.Controllers
{
    public class NQM_Controller : Controller
    {
        // GET: NQM_
        public ActionResult Index()
        {
            ViewData["msg"] = "dữ liệu trong view data";
            return View();
        }

        public ActionResult StudentList()
        {
            string[] names = { "manh manh", "ho bao", "soc nho" };
            ViewBag.Names = names;
            return View();
        }
        public ActionResult Insert() { 
            return View("Addstudent");
        }
    }
}
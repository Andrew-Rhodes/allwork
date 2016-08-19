using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace URLRouting.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        public ActionResult list()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "CustomVariable";
            return View("ActionName");
        }
    }
}
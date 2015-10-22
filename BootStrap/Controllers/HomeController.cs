using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootStrap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            int[] array = new int[] { 3, 1, 4, 5, 2 };
            Array.Sort<int>(array,
                            new Comparison<int>(
                                    (i1, i2) => i2.CompareTo(i1)
                            ));

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
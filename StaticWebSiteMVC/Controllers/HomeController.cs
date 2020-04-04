using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StaticWebSiteMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [Route("About")]
        public ActionResult About()
        {
            return View();
        }
        [Route("Products")]
        public ActionResult Products()
        {
            return View();
        }
        [Route("Store")]
        public ActionResult Store()
        {
            return View();
        }
    }
}
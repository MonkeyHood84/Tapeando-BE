using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tapeando.API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.Redirect("/Help");

            //ViewBag.Title = "Home Page";

            //return View();
        }
    }
}

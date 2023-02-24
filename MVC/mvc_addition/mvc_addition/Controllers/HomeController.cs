using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_addition.Models;

namespace mvc_addition.Controllers
{
    public class HomeController : Controller
    {
       [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(add a1)
        {
            a1.f = a1.a + a1.b + a1.c + a1.d + a1.e;
            return View(a1);
        }
    }
}
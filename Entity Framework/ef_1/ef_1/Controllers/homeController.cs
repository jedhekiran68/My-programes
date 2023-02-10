using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ef_1.Models;

namespace ef_1.Controllers
{
    public class HomeController : Controller
    {
        staffcontext sc = new staffcontext();
          

        // GET: Home
        public ActionResult Index()
        {
            var d = sc.s1.ToList();


            return View(d);
        }
    }
}
using ef_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ef_2.Controllers
{
    public class HomeController : Controller
    {
        collegecontext p1 = new collegecontext();
        // GET: Home
        public ActionResult Index()
        {
            var d = p1.c1.ToList();


            return View(d);
        }

        [HttpGet]
        public ActionResult create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult create(college z)
        {
            p1.c1.Add(z);
            p1.SaveChanges();
            Response.Write("<script>alert('data insert into table')</script>");

            return View();
        }

        [HttpGet]
        public ActionResult delete()
        {
        return View();
        }

        [HttpPost]
        public ActionResult delete(college y)
        {
            p1.c1.Remove(y);
            p1.SaveChanges();
            Response.Write("<script>alert('data delete from table')</script>");

            return View();
        }

    }
}
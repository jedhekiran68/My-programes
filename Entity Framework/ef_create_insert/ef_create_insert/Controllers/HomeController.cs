using ef_create_insert.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ef_create_insert.Controllers
{
    public class HomeController : Controller
    {

        companycontext cc = new companycontext();
        // GET: Home
        public ActionResult Index()
        {

            var d = cc.c1.ToList();
            return View(d);
        }

        [HttpGet]
        public ActionResult create()
        {        
            return View();
        }

        [HttpPost]
        public ActionResult create(company z)
        {
            cc.c1.Add(z);
            cc.SaveChanges();
            Response.Write("<script>alert('data insert successfully')</script>");

            return View();
        }

       /* [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(company z)
        {
            cc.c1.Remove(z);
            cc.SaveChanges();
            Response.Write("<script>alert('data delete successfully')</script>");

            return View();
        }*/
    }
}
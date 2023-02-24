using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_task_add_sub_mult_div.Models;

namespace mvc_task_add_sub_mult_div.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(addition a1)
        {
            a1.c = a1.a + a1.b;
            return View(a1);
        }


        [HttpGet]
        public ActionResult substraction()
        {
            return View();
        }

        [HttpPost]
        public ActionResult substraction(substraction s1)
        {
            s1.z = s1.x - s1.y;
            return View(s1);
        }

        [HttpGet]
        public ActionResult mult()
        {
            return View();
        }

        [HttpPost]
        public ActionResult mult(mult m1)
        {
            m1.r = m1.p * m1.q;
            return View(m1);
        }

        [HttpGet]
        public ActionResult division()
        {
            return View();
        }

        [HttpPost]
        public ActionResult division(div d1)
        {
            d1.a = d1.m / d1.b;
            return View(d1);
        }
    }
}
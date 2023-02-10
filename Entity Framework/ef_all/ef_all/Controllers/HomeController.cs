﻿using ef_all.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ef_all.Controllers
{
    public class HomeController : Controller
    {
        familycontext fc = new familycontext();

        // GET: Home
        public ActionResult Index()
        {
          var v=  fc.f1.ToList();

            return View(v);
        }


        [HttpGet]
        public ActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Create(family f)
        {
            fc.f1.Add(f);
            fc.SaveChanges();
            Response.Write("<script>alert('data insert successfully')</script>");
            return View();
        }


        [HttpGet]

        public ActionResult Delete(int z)
        {
            var t = fc.f1.Where(model => model.fid == z).FirstOrDefault();
            return View(t);
        }

        [HttpPost]

        public ActionResult Delete(family q)
        {
            fc.Entry(q).State =System.Data.Entity.EntityState.Deleted;
            fc.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
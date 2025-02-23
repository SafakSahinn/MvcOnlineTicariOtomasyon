﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyon.Models.Sınıflar;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class UrunDetayController : Controller
    {
        // GET: UrunDetay
        Context c = new Context();

        public ActionResult Index()
        {
            var degerler = c.Uruns.ToList();
            return View(degerler);
        }

        public ActionResult UrunDetay(int id)
        {
            var degerler = c.Uruns.Where(x => x.UrunID == id).ToList();
            return View("UrunDetay", degerler);
        }
    }
}
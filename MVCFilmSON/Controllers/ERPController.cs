using MVCFilmSON.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilmSON.Controllers
{
    public class ERPController : Controller
    {
        // GET: ERP
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Yerli()
        {
            ApplicationDbContext ctx = new ApplicationDbContext();
            return View(ctx.Filmler.Where(x => !x.Yabanci).ToList());
        }

        public ActionResult Yabanci()
        {
            ApplicationDbContext ctx = new ApplicationDbContext();
            return View(ctx.Filmler.Where(x => x.Yabanci).ToList());
        }

        public ActionResult Yil(short y)
        {
            ApplicationDbContext ctx = new ApplicationDbContext();
            return View(ctx.Filmler.Where(x => x.Yil == y).ToList());
        }
    }
}
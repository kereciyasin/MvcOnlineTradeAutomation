using System;
using System.Collections.Generic;
using System.Linq;
using MvcOnlineTradeAutomation.Data;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTradeAutomation.Models;

namespace MvcOnlineTradeAutomation.Controllers
{
    public class CategoryController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Categories.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(Category p)
        {
            c.Categories.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
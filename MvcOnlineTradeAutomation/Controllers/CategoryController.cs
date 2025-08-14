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

        public ActionResult DeleteCategory(int id)
        {
            var category = c.Categories.Find(id);
            c.Categories.Remove(category);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var category = c.Categories.Find(id);
            return View(category);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category p)
        {
            var category = c.Categories.Find(p.CategoryID);
            category.CategoryName = p.CategoryName;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
using MvcOnlineTradeAutomation.Data;
using MvcOnlineTradeAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineTradeAutomation.Controllers
{
    public class ProductController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {
            var products = db.Products.Where(x => x.Status == true).ToList();
            return View(products);
        }
        public ActionResult CreateProduct()
        {
            ViewBag.Categories = db.Categories.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {

            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult DeleteProduct(int id)
        {
            var product = db.Products.Find(id);
            product.Status = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
using MvcOnlineTradeAutomation.Data;
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
            var products = db.Products.Include("Category").ToList();
            return View(products);
        }
    }
}
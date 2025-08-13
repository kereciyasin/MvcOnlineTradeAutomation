using System;
using System.Collections.Generic;
using System.Linq;
using MvcOnlineTradeAutomation.Data;
using System.Web;
using System.Web.Mvc;

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
    }
}
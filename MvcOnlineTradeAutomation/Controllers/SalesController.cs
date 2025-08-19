using MvcOnlineTradeAutomation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineTradeAutomation.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        Context db = new Context();
        public ActionResult Index()
        {
            var sales = db.SalesTransactions.ToList();
            return View(sales);
        }
    }
}
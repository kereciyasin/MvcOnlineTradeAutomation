using MvcOnlineTradeAutomation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineTradeAutomation.Controllers
{
    public class InvoiceController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            var invoices = context.Invoices
                            .OrderByDescending(x => x.Date)
                            .ToList();
            return View(invoices);
        }
    }
}
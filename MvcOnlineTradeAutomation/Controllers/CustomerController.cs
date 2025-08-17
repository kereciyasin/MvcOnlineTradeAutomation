using MvcOnlineTradeAutomation.Data;
using MvcOnlineTradeAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineTradeAutomation.Controllers
{
    public class CustomerController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {
            var values = db.Customers.ToList();
            return View(values);
        }
        public ActionResult CreateCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCustomer(int id)
        {
            var customer = db.Customers.Find(id);

            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
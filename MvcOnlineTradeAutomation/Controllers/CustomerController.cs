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
            var values = db.Customers.Where(x => x.Status == true).ToList();
            return View(values);
        }
        public ActionResult CreateCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCustomer(Customer customer)
        {
            customer.Status = true; // Assuming new customers are active by default 
            db.Customers.Add(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCustomer(int id)
        {
            var customer = db.Customers.Find(id);
            customer.Status = false; // Soft delete by setting status to false
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
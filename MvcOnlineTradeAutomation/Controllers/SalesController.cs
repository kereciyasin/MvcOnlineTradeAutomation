using MvcOnlineTradeAutomation.Data;
using MvcOnlineTradeAutomation.Models;
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
        public ActionResult CreateSale()
        {
            List<SelectListItem> products = (from x in db.Products.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.ProductName,
                                                 Value = x.ProductID.ToString()
                                             }).ToList();

            List<SelectListItem> customers = (from x in db.Customers.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = x.FirstName + " " + x.LastName,
                                                  Value = x.CustomerID.ToString()
                                              }).ToList();

            List<SelectListItem> employees = (from x in db.Employees.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = x.FirstName + " " + x.LastName,
                                                  Value = x.EmployeeID.ToString()
                                              }).ToList();
            ViewBag.products = products;
            ViewBag.customers = customers;
            ViewBag.employees = employees;
            return View();
        }
        [HttpPost]
        public ActionResult CreateSale(SalesTransaction s)
        {
            s.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.SalesTransactions.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateSale(int id)
        {
            var sale = db.SalesTransactions.Find(id);
            List<SelectListItem> products = (from x in db.Products.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.ProductName,
                                                 Value = x.ProductID.ToString()
                                             }).ToList();
            List<SelectListItem> customers = (from x in db.Customers.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = x.FirstName + " " + x.LastName,
                                                  Value = x.CustomerID.ToString()
                                              }).ToList();
            List<SelectListItem> employees = (from x in db.Employees.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = x.FirstName + " " + x.LastName,
                                                  Value = x.EmployeeID.ToString()
                                              }).ToList();
            ViewBag.products = products;
            ViewBag.customers = customers;
            ViewBag.employees = employees;
            return View("UpdateSale", sale);
        }
        public ActionResult UpdateSale(SalesTransaction s)
        {
            var sale = db.SalesTransactions.Find(s.SalesTransactionID);
            sale.ProductID = s.ProductID;
            sale.CustomerID = s.CustomerID;
            sale.EmployeeID = s.EmployeeID;
            sale.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            sale.Quantity = s.Quantity;
            sale.Price = s.Price;
            sale.TotalAmount = s.TotalAmount;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SalesDetails(int id)
        {
            var value = db.SalesTransactions.Where(x => x.SalesTransactionID == id).ToList();
            return View(value);
        }

    }
}
using MvcOnlineTradeAutomation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineTradeAutomation.Controllers
{
    public class EmployeeController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {
            var values = db.Employees.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateEmployee()
        {
            List<SelectListItem> value = (from x in db.Employees.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.Department.DepartmentName,
                                              Value = x.DepartmentID.ToString()
                                          }).ToList();
            ViewBag.value1 = value;
            return View();
        }
        [HttpPost]
        public ActionResult CreateEmployee(Models.Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
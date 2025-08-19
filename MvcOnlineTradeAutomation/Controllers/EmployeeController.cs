using MvcOnlineTradeAutomation.Data;
using MvcOnlineTradeAutomation.Models;
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
        public ActionResult UpdateEmployee(int id)
        {
            List<SelectListItem> value = (from x in db.Departments.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.DepartmentName,
                                              Value = x.DepartmentID.ToString()
                                          }).ToList();
            ViewBag.value1 = value;
            var employee = db.Employees.Find(id);
            return View("UpdateEmployee", employee);
        }
        [HttpPost]
        public ActionResult UpdateEmployee(Employee p)
        {
            var emp = db.Employees.Find(p.EmployeeID);
            emp.FirstName = p.FirstName;
            emp.LastName = p.LastName;
            emp.ImageUrl = p.ImageUrl;
            emp.DepartmentID = p.DepartmentID;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
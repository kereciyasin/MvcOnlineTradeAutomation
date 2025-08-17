using MvcOnlineTradeAutomation.Data;
using MvcOnlineTradeAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineTradeAutomation.Controllers
{
    public class DepartmentController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {
            var values = db.Departments.Where(x => x.Status == true).ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateDepartment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateDepartment(Department department)
        {
            db.Departments.Add(department);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteDepartment(int id)
        {
            var department = db.Departments.Find(id);
            department.Status = false; // Soft delete
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateDepartment(int id)
        {
            var department = db.Departments.Find(id);
            return View("UpdateDepartment", department);
        }
        [HttpPost]
        public ActionResult UpdateDepartment(Department department)
        {
            var existingDepartment = db.Departments.Find(department.DepartmentID);
            existingDepartment.DepartmentName = department.DepartmentName;
            existingDepartment.Status = department.Status; // Assuming you want to keep the status field
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmentDetails(int id)
        {
            var department = db.Employees.Where(x => x.DepartmentID == id).ToList();
            var dpt = db.Departments.Where(x => x.DepartmentID == id).Select(y => y.DepartmentName).FirstOrDefault();
            ViewBag.DepartmentName = dpt;
            return View(department);
        }
        public ActionResult EmployeeSales(int id)
        {
            var value = db.SalesTransactions.Where(x => x.EmployeeID == id).ToList();
            var per = db.Employees.Where(x => x.EmployeeID == id).Select(y => y.FirstName + " " + y.LastName).FirstOrDefault();
            ViewBag.EmployeeName = per;
            return View(value);
        }
    }
}
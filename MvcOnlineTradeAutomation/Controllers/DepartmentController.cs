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
            db.Departments.Remove(department);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateDepartment(int id)
        {
            var department = db.Departments.Find(id);
            return View(department);
        }
        [HttpPost]
        public ActionResult UpdateDepartment(Department department)
        {
            var existingDepartment = db.Departments.Find(department.DepartmentID);
            existingDepartment.DepartmentName = department.DepartmentName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTradeAutomation.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }

        public string DepartmentName { get; set; }
        // One department has many employees
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
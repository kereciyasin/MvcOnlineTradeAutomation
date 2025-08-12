using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTradeAutomation.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string DepartmentName { get; set; }
        // One department has many employees
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
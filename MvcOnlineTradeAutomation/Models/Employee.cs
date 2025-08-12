using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTradeAutomation.Models
{
    public class Employee
    {
        [Key] public int EmployeeID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string LastName { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(500)]
        public string ImageUrl { get; set; }

        public virtual ICollection<SalesTransaction> SalesTransactions { get; set; }
        // FK to Department
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
    }
}
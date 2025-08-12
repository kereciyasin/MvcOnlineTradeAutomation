using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTradeAutomation.Models
{
    public class SalesTransaction
    {
        [Key]
        public int SalesTransactionID { get; set; }

        // Relations (foreign keys)
        //public int ProductID { get; set; }
        //public virtual Product Product { get; set; }

        //public int CustomerID { get; set; }
        //public virtual Customer Customer { get; set; }

        //public int EmployeeID { get; set; }
        //public virtual Employee Employee { get; set; }

        public DateTime Date { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal TotalAmount { get; set; }
    }
}
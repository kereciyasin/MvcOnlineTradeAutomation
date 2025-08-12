using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTradeAutomation.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string Brand { get; set; }

        public short Stock { get; set; }

        public decimal PurchasePrice { get; set; }

        public decimal SalePrice { get; set; }

        public bool Status { get; set; }
        public string ImageUrl { get; set; }

        // Category relationship    
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
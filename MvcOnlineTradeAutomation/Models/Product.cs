using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTradeAutomation.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string ProductName { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Brand { get; set; }
        public short Stock { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public bool Status { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(500)]
        public string ImageUrl { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        // back-reference (opsiyonel)
        public virtual ICollection<SalesTransaction> SalesTransactions { get; set; }
    }
}
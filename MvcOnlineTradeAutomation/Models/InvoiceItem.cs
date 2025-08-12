using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTradeAutomation.Models
{
    public class InvoiceItem
    {
        [Key]
        public int InvoiceItemID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Description { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Total { get; set; }

        // INVOICE ITEM RELATED TO INVOICE
        public int InvoiceID { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
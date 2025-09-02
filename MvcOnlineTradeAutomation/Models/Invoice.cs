using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTradeAutomation.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        [Column(TypeName = "char")]
        [StringLength(1)]
        public string InvoiceSerialNumber { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(6)]
        public string InvoiceSequenceNumber { get; set; }

        public DateTime Date { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(60)]
        public string TaxOffice { get; set; }

        public DateTime Time { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string DeliveredBy { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string ReceivedBy { get; set; }
        public decimal? TotalAmount { get; set; }


        // Invoice items are related to the Invoice
        public ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}
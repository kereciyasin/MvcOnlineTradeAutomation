using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTradeAutomation.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }

        public string InvoiceSerialNumber { get; set; }

        public string InvoiceSequenceNumber { get; set; }

        public DateTime Date { get; set; }

        public string TaxOffice { get; set; }

        public DateTime Time { get; set; }

        public string DeliveredBy { get; set; }

        public string ReceivedBy { get; set; }
    }
}
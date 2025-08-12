using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTradeAutomation.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseID { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Description { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }
    }
}
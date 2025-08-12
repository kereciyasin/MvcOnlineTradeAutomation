using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTradeAutomation.Models
{
    public class Customer
    {
        [Key] public int CustomerID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string LastName { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string City { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Email { get; set; }

        public virtual ICollection<SalesTransaction> SalesTransactions { get; set; }


    }
}
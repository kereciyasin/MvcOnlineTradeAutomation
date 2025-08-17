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
        [Key]
        public int CustomerID { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<SalesTransaction> SalesTransactions { get; set; }
    }
}

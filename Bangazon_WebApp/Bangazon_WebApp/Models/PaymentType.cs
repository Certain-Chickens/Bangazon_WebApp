using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

// Author: Robbie Stock
// Purpose: Creating and maintaing the Payment Type table.

namespace Bangazon_WebApp.Models
{
    public class PaymentType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public ApplicationUser ApplicationUser { get; set; }
        public string PaymentName { get; set; }
        public string AccountNumber { get; set; }

        public ICollection<Order> Orders;
    }
}

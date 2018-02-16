using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon_WebApp.Models
{
    public class PaymentTypeModel
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

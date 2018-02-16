using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon_WebApp.Models
{
    public class ProductTypeModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string PaymentName { get; set; }
        public string AccountNumber { get; set; }

    }
}

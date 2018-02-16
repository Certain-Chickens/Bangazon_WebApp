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
        public string PaymentName { get; set; }
        public string AccountNumber { get; set; }

        ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}

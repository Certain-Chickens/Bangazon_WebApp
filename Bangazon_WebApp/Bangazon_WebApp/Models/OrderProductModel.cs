using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon_WebApp.Models
{
    public class OrderProductModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public ProductModel Product { get; set; }

        [Required] 
        public OrderModel Order { get; set; }
    }
}

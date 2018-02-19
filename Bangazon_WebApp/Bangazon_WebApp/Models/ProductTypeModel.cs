using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

// Author: Ryan McPherson
// Purpose: Creates table and connections for the ProductType table

namespace Bangazon_WebApp.Models
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Category")]
        public string Name { get; set; }

        public virtual ICollection<ProductModel> Products { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

// Author: Ryan McPherson
// Purpose: Creates table and connections for the Recommendations table

namespace Bangazon_WebApp.Models
{
    public class RecommendationsModel
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public ApplicationUser Sender { get; set; }

        [Required]
        public ApplicationUser Recipient { get; set; }

        [Required]
        public ProductModel Product { get; set; }

    }
}

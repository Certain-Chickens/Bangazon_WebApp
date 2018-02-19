﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

// Author: Ryan McPherson
// Purpose: Creating and maintaing the Product Rating table.

namespace Bangazon_WebApp.Models
{
    public class ProductRatingModel
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public ApplicationUser ApplicationUser { get; set; }
        public ProductModel Products { get; set; }
        public double Rating { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

// Author: Ryan McPherson
// Purpose: Creates table and connections for the Product table

namespace Bangazon_WebApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        [StringLength(55, ErrorMessage = "Please shorten the product title to 55 characters")]
        public string Title { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Price { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        public int LocalDelivery { get; set; }

        public string DeliveryCity { get; set; }

        public byte[] Photo { get; set; }


        // Foreign Keys

        public ProductType ProductType { get; set; }

        //public Recommendations Recommendations { get; set; }

        public virtual ICollection<Likes> Likes { get; set; }

        public virtual ICollection<ProductRating> ProductRating { get; set; }

        public virtual ICollection<OrderProduct> OrderProduct { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


// Author: Robbie Stock
// Purpose: Creating and maintaing the Likes Rating table.

namespace Bangazon_WebApp.Models
{
    public class LikesModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public ApplicationUser ApplicationUser { get; set; }
        public ProductModel Products { get; set; }
        public int Liked { get; set; }
    }
}

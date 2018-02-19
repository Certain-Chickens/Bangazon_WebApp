using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//Author: Ray
//Purpose: This is the database model for the Photos Table

namespace Bangazon_WebApp.Models
{
    public class PhotosModel
    {
        [Key]
        public int Id { get; set; }

        public byte[] Photo { get; set; }

        //forign key relationship

        public ProductModel Products { get; set; }
    }
}

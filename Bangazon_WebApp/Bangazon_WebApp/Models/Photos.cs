using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//Author: Ray
//Purpose: This is the database model for the Photos Table

namespace Bangazon_WebApp.Models
{
    public class Photos
    {
        [Key]
        public int Id { get; set; }

        public byte[] Photo { get; set; }

        //forign key relationship

        public Product Products { get; set; }
    }
}

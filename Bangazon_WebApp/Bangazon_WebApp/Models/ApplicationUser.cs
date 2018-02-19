using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Bangazon_WebApp.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        

        [Required]
        [Display(Name = "Fist Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [StringLength(2)]
        public string State { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

    

        //Foreign Key relationships

        public virtual ICollection<PaymentType> PaymentTypes { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        //public virtual ICollection<Recommendations> Recommendations { get; set; }

        public virtual ICollection<Likes> Likes { get; set; }

        public virtual ICollection<ProductRating> ProductRatings { get; set; }


        
    }
}

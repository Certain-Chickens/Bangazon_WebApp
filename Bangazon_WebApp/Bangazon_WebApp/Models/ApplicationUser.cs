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

        public virtual ICollection<PaymentTypeModel> PaymentTypes { get; set; }

        public virtual ICollection<OrdersModel> Orders { get; set; }

        public virtual ICollection<ProductsModel> Products { get; set; }

        public virtual ICollection<RecommendationsModel> Recommendations { get; set; }

        public virtual ICollection<LikesModel> Likes { get; set; }

        public virtual ICollection<ProductRatingModel> ProductRatings { get; set; }


        
    }
}

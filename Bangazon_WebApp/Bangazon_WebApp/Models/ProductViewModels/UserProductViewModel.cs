using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Bangazon_WebApp.Models;

//Author Ray
//Purpose - This viewmodel is used when the user clicks on the My Product Affordance
// It is connected to the MyProducts Method in the Products Controller

namespace Bangazon_WebApp.Models.ProductViewModels
{
    public class UserProductViewModel
    {
        public Product product { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}

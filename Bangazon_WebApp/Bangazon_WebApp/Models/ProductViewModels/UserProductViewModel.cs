using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Bangazon_WebApp.Models;

namespace Bangazon_WebApp.Models.ProductViewModels
{
    public class UserProductViewModel
    {
        public Product product { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}

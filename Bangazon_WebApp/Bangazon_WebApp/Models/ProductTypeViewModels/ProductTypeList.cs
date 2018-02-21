//Author:  Erin Agobert
//Purpose:  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon_WebApp.Models.ProductTypeViewModels
{
    public class ProductTypeList
    {
        public ProductType ProductType { get; set; }
        public List<Product> Products { get; set; }
    }
}

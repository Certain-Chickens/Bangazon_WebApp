//Author:  Erin Agobert
//Purpose:  A model of the list view by product type
using System.Collections.Generic;


namespace Bangazon_WebApp.Models.ProductTypeViewModels
{
    public class ProductTypeListModel
    {
        public ProductType ProductType { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}

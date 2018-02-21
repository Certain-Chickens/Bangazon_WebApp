using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Threading.Tasks;
using Bangazon_WebApp.Models;
using Bangazon_WebApp.Data;

namespace Bangazon_WebApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider, UserManager<ApplicationUser> userManager)
        {
            var context = serviceProvider.GetRequiredService<ApplicationDbContext>();

            context.Database.EnsureCreated();

            // Look for any products.
            if (!context.ProductType.Any())
            {

                context.ProductType.Add(new ProductType { Name = "Electronics" });
                context.ProductType.Add(new ProductType { Name = "Appliances" });
                context.ProductType.Add(new ProductType { Name = "Housewares" });

                context.SaveChanges();
            }


            // Look for any product.
            if (!context.Product.Any())
            {
                ApplicationUser user1 = userManager.FindByNameAsync("mmcpher2@gmail.com").Result;
                ApplicationUser user2 = userManager.FindByNameAsync("eagobert1@gmail.com").Result;

                ProductType productCatergoryId1 = (from pt in context.ProductType
                                           where pt.Name.Equals("Electronics")
                                           select pt).Single();

               ProductType productCatergoryId2 = (from pt in context.ProductType
                                           where pt.Name.Equals("Appliances")
                                           select pt).Single();

                ProductType productCatergoryId3 = (from pt in context.ProductType
                                           where pt.Name.Equals("Housewares")
                                           select pt).Single();


                context.Product.Add(new Product
                {

                    Quantity = 1,
                    DateCreated = DateTime.Now,
                    Description = "Gaming System",
                    ProductType = productCatergoryId1,
                    Title = "XBox One",
                    Price = 123.34,
                    User = user1,
                    LocalDelivery = 1,
                    DeliveryCity = "Nashville, TN",
                    Photo = null

                });

                context.Product.Add(new Product
                {

                    Quantity = 3,
                    DateCreated = DateTime.Now,
                    Description = "Microwave",
                    ProductType = productCatergoryId2,
                    Title = "Nice Microwave",
                    Price = 20.00,
                    User = user1,
                    LocalDelivery = 1,
                    DeliveryCity = "Nashville, TN",
                    Photo = null
                });

                context.Product.Add(new Product
                {

                    Quantity = 2,
                    DateCreated = DateTime.Now,
                    Description = "Large picture frame.",
                    ProductType = productCatergoryId3,
                    Title = "Picture Frame",
                    Price = 65.98,
                    User = user1,
                    LocalDelivery = 0,
                    DeliveryCity = null,
                    Photo = null
                });

                    context.Product.Add(new Product
                    {

                        Quantity = 1,
                        DateCreated = DateTime.Now,
                        Description = "Gaming System",
                        ProductType = productCatergoryId1,
                        Title = "Playstation 4",
                        Price = 123.34,
                        User = user2,
                        LocalDelivery = 1,
                        DeliveryCity = "Nashville, TN",
                        Photo = null

                    });

                    context.Product.Add(new Product
                    {

                        Quantity = 3,
                        DateCreated = DateTime.Now,
                        Description = "Blender",
                        ProductType = productCatergoryId2,
                        Title = "Kitchenaid Blender",
                        Price = 20.00,
                        User = user2,
                        LocalDelivery = 1,
                        DeliveryCity = "Nashville, TN",
                        Photo = null
                    });

                    context.Product.Add(new Product
                    {

                        Quantity = 2,
                        DateCreated = DateTime.Now,
                        Description = "Lamp with lampshade",
                        ProductType = productCatergoryId3,
                        Title = "Lamp",
                        Price = 65.98,
                        User = user2,
                        LocalDelivery = 0,
                        DeliveryCity = null,
                        Photo = null
                    });

                    context.SaveChanges();

                }
            }
        }
 
}
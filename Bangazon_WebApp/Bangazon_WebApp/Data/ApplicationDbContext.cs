//Author: Erin Agobert
//Purposed:  Create DBSets for each table connection and set standard format for date/time
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bangazon_WebApp.Models;

namespace Bangazon_WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUser {get; set;}
        public DbSet<Likes> Likes {get; set;}
        public DbSet<Order> Order {get; set;}
        public DbSet<OrderProduct> OrderProduct {get; set;}
        public DbSet<PaymentType> PaymentType {get; set;}
        public DbSet<Product> Product {get; set;}
        public DbSet<ProductRating> ProductRating {get; set;}
        public DbSet<ProductType> ProductType {get; set;}
        //public DbSet<Recommendations> Recommendations {get; set;}

protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            modelBuilder.Entity<Product>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("GETDATE()");

            //modelBuilder.Entity<Order>()
              //.Property(c => c.DateTimeCreated)
              //.HasDefaultValueSql("GETDATE()");

            //modelBuilder.Entity<Order>()
              //.Property(d => d.DateTimeClosed)
              //.HasDefaultValueSql("GETDATE()");
        }
    }
}

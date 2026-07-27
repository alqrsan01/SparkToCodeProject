using ECommerceApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp
{
    public class ProjectContext : DbContext
    {
        public DbSet<User> Uuser { get; set; }
        public DbSet<Category> Ccategory { get; set; }
        public DbSet<Order> Oorder { get; set; }
        public DbSet<Order_Product> OPorder_product { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=Alqrsan\\SQLEXPRESS;Database=E-Commerce;Trusted_Connection=True;TrustServerCertificate=True;"
                );
        }
    }
}

using ECommerceWeb.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceWeb.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                 new Category { Id = 1, Name = "Books", Url = "books", Icon = "book" },
                new Category { Id = 2, Name = "Phones", Url = "phones", Icon = "phone" },
                new Category { Id = 3, Name = "Toys", Url = "toys", Icon = "puzzle-piece" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Iphone 15 PRO MAX ULTRA AMAZING LAST VERSION PRIME EDITION",
                    Description = "Iphone is the most iconic phone ever. If you have this phone you look rich :)",
                    Image = "https://e7.pngegg.com/pngimages/599/150/png-clipart-iphone-x-front-view-apple%E6%89%8B%E6%9C%BA-iphone-thumbnail.png",
                    Price = 100.000m,
                    OriginalPrice = 99.999m,
                },
        new Product
        {
            Id = 2,
            CategoryId = 3,
            Title = "Half-Life",
            Description = "Gun and guns Half-Life is most iconic game ever",
            Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
            Price = 10.99m,
            OriginalPrice = 49.99m,
        },
        new Product
        {
            Id = 3,
            CategoryId = 2,
            Title = "Half-Life",
            Description = "Gun and guns Half-Life is most iconic game ever",
            Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
            Price = 10.99m,
            OriginalPrice = 49.99m,
        }
                );  
        }
    }
}

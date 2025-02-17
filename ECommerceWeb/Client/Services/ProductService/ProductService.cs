using ECommerceWeb.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceWeb.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void LoadProducts()
        {
            Products = new List<Product>
            {
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
            };
        }
    }
}

using ECommerceWeb.Server.Services.CategoryService;
using ECommerceWeb.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceWeb.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;

        public ProductService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public List<Product> Products { get; set; } = new List<Product>
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
        new Product
        {
              Id = 3,
            CategoryId = 2,
            Title = "Half-Life",
            Description = "Gun and guns Half-Life is most iconic game ever",
            Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
            Price = 10.99m,
            OriginalPrice = 49.99m,
        },
            };

        public async Task<List<Product>> GetAllProducts()
        {
            return Products;
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return Products.Where(p => p.CategoryId == category.Id).ToList();
        }
    }
}

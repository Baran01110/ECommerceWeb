using ECommerceWeb.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceWeb.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>
            {
                new Category {Id=1, Name = "Books" , Url = "books", Icon = "book"},
                new Category {Id=2, Name = "Phones" , Url = "phones", Icon = "phone"},
                new Category {Id=3, Name = "Toys" , Url = "toys", Icon = "puzzle-piece"}

            };

        public async Task<List<Category>> GetCategories()
        {
            return Categories;
        }
    }
}

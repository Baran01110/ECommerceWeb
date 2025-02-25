﻿using ECommerceWeb.Server.Data;
using ECommerceWeb.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceWeb.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }

        //public List<Category> Categories { get; set; } = new List<Category>
        //    {
        //        new Category {Id=1, Name = "Books" , Url = "books", Icon = "book"},
        //        new Category {Id=2, Name = "Phones" , Url = "phones", Icon = "phone"},
        //        new Category {Id=3, Name = "Toys" , Url = "toys", Icon = "puzzle-piece"}

        //    };

        public async Task<List<Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}

using ECommerceWeb.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceWeb.Server.Services.CategoryService
{
   public interface ICategoryService
    {
        Task<List<Category>> GetCategories();
    }
}

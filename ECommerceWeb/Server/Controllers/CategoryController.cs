using ECommerceWeb.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]

        public async Task< ActionResult<List<Category>>> GetCategories()
        {
            return Ok(new List<Category>
            {
                new Category {Id=1, Name = "Books" , Url = "books", Icon = "book"},
                new Category {Id=2, Name = "Phones" , Url = "phones", Icon = "phone"},
                new Category {Id=3, Name = "Toys" , Url = "toys", Icon = "puzzle-piece"}

            });
        }
    }
}

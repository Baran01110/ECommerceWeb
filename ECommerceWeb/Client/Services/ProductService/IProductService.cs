using ECommerceWeb.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceWeb.Client.Services.ProductService
{
    interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();
    }
}

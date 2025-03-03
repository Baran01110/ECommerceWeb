using Blazored.LocalStorage;
using Blazored.Toast;
using ECommerceWeb.Client.Services.CartService;
using ECommerceWeb.Client.Services.CategoryService;
using ECommerceWeb.Client.Services.ProductService;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceWeb.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<ICartService, CartService > ();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddBlazoredToast();

            await builder.Build().RunAsync();
        }
    }
}

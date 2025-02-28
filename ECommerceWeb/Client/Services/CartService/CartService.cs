using Blazored.LocalStorage;
using Blazored.Toast.Services;
using ECommerceWeb.Client.Services.ProductService;
using ECommerceWeb.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceWeb.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IToastService _toastService;
        private readonly IProductService _productService;

        public event Action OnChange;

        public CartService(ILocalStorageService localStorage, IToastService toastService, IProductService productService)
        {
            _localStorage = localStorage;
            _toastService = toastService;
            _productService = productService;
        }

        public async Task AddToCart(Product product)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            var cartItem = new CartItem
            {
                ProductId = product.Id,
                ProductTitle = product.Title,
                Image = product.Image,
                Price = product.Price
            };

            cart.Add(cartItem);
            await _localStorage.SetItemAsync("cart", cart);

            _toastService.ShowSuccess(product.Title, "Added to cart:");

            OnChange?.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var result = new List<CartItem>();
            var cart = await _localStorage.GetItemAsync<List<Product>>("cart");
            if(cart == null)
            {
                return result;
            }
            foreach (var item in cart)
            {
                var product = await _productService.GetProduct(item.Id);
                var cartItem = new CartItem
                {
                    ProductId = product.Id,
                    ProductTitle = product.Title,
                    Image = product.Image,
                    Price = product.Price
                };
                result.Add(cartItem);
            }
            return result;
        }
    }
}

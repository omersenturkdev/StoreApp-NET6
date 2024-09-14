using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Contracts;

namespace StoreApp.Pages
{
    public class CartModel : PageModel
    {
        private readonly IServiceManager _manager;
        public Cart Cart { get; set; }

        public CartModel(IServiceManager manager,Cart cart)
        {
            _manager = manager;
            Cart  = cart;
        }
        
        public string ReturnUrl { get; set; } = "/";
        public void OnGet(string returnUrl)
        {
            ReturnUrl = ReturnUrl ?? "/";
        }
        public IActionResult OnPost(int productId, string returnUrl)
        {
          Product? product = _manager.ProductService.GetOneProduct(productId,false);
          if(product is not null)
          {
            Cart.AddItem(product,1);
          }
          return Page();
        }

        public IActionResult OnPostRemove(int id, string returnUrl)
        {
            var line = Cart.Lines.FirstOrDefault(cl => cl.Product.ProductId == id);
            if (line != null)
            {
                Cart.RemoveLine(line.Product);
            }
            return Page();
        }

    }
}
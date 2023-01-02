using BakeryShop.Data;
using BakeryShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BakeryShop.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        private readonly BakeryShopContext _bakeryShopContext;
        public IndexModel (BakeryShopContext bakeryShopContext)=> this._bakeryShopContext = bakeryShopContext;

        public List<Product> Products { get; set; }
        public Product Feature { get; set; }

        public async Task OnGetAsync()
        {
            Products = await _bakeryShopContext.Products.ToListAsync();

            Feature = Products.ElementAt(new Random().Next(Products.Count));    
        }
    }
}
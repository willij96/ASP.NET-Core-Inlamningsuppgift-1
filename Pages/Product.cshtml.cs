using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion1.Data;
using FreakyFashion1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FreakyFashion1
{
    public class ProductModel : PageModel
    {
        private readonly ILogger<ProductModel> logger;
        private readonly ApplicationDbContext context;

        public IList<Product> ProductList = new List<Product>();

        public Product Product { get; set; }

        public ProductModel(ApplicationDbContext context, ILogger<ProductModel> logger)
        {
            this.logger = logger;
            this.context = context;
        }

        public void OnGet(string urlSlug)
        {
            Product = context.Product.FirstOrDefault(x => x.UrlSlug == urlSlug);

            ProductList = context.Product
                .ToList();
        }
    }
}
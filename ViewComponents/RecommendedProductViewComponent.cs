using FreakyFashion1.Data;
using FreakyFashion1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion1.ViewComponents
{
    public class RecommendedProductViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext context;

        public RecommendedProductViewComponent(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IViewComponentResult Invoke(IList<Product> products)
        {
            return View(products);
        }
    }
}

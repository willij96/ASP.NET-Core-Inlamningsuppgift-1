using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion1.Areas.Admin.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext context;

        public IEnumerable<Models.Product> Products { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void OnGet()
        {
            Products = context.Product
                .Include(x=>x.ProductCategories)
                .ThenInclude(x=>x.Category).ToList();


        }
    }
}

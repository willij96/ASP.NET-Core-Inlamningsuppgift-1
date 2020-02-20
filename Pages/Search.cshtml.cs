using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion1.Data;
using FreakyFashion1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace FreakyFashion1
{
    public class SearchModel : PageModel
    {

        private readonly ApplicationDbContext _context;

        public SearchModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public IList<Product> Product { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;


        public async Task OnGetAsync([FromQuery] string q)
        {
            var products = from m in _context.Product
                         select m;
            if (!string.IsNullOrEmpty(q))
            {
                products = products.Where(s => s.Name.Contains(q));
            }

            Product = await products.ToListAsync();

        }
    }
}
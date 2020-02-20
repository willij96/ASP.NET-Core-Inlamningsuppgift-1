using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion1.Data;
using FreakyFashion1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion1
{
    public class CategoryModel : PageModel
    {
        public string name { get; set; }

        private readonly ApplicationDbContext applicationDbContext ;
        public CategoryModel(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public List<Category> categories { get; set; }
        public Category category { get; set; }
        public void OnGet(string name)
        {
            category = applicationDbContext.Category
                .Include(x => x.ProductCategories)
                .ThenInclude(x => x.Product)
                .FirstOrDefault(x => x.Name == name);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion1.Data;
using FreakyFashion1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FreakyFashion1.Areas.Admin.Pages.Product
{
    public class NewModel : PageModel
    {
        private readonly ApplicationDbContext context;

        [BindProperty]
        public Models.Product ViewModel { get; set; }

        [BindProperty]
        public NewCategoryViewModel CategoryViewModel { get; set; }

        public NewModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            CategoryViewModel = new NewCategoryViewModel();

            CategoryViewModel.CategoryList = context.Category
                .ToList()
                .Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Name
                });
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            string urlSlug = ViewModel.Name.Replace(' ', '-');

            ViewModel.UrlSlug = urlSlug;

            var category = new Models.Category(
                CategoryViewModel.CategoryId
                );

            var product = new Models.Product(
                ViewModel.Name,
                ViewModel.ArticleNumber,
                ViewModel.Description,
                ViewModel.ImageUrl,
                ViewModel.Price,
                ViewModel.UrlSlug
                );

            var productCategory = new ProductCategory(
                category.Id,
                product
                );

            context.ProductCategory.Add(productCategory);

            context.SaveChanges();

            return RedirectToPage("Index");
        }

        public class Product
        {
            [Required]
            public string Name { get; set; }
            [Required]
            public string ArticleNumber { get; set; }
            [Required]
            public string Description { get; set; }          
            [Required]
            public int Price { get; set; }
            [Required]
            public Uri ImageUrl { get; set; }
            [Required]
            public string UrlSlug { get; set; }
        }

        public class NewCategoryViewModel
        {

            public IEnumerable<SelectListItem> CategoryList { get; set; }

            [Required]
            public int CategoryId { get; set; }
        }
    }
}

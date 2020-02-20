﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FreakyFashion1.Data;
using FreakyFashion1.Models;

namespace FreakyFashion1
{
    public class CreateModel : PageModel
    {
        private readonly FreakyFashion1.Data.ApplicationDbContext _context;

        public CreateModel(FreakyFashion1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //var category = new Category(Category.Id);

            _context.Category.Add(Category);

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

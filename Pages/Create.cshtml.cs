using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinalProject_BloggingNewsSite.Data;
using FinalProject_BloggingNewsSite.Models;

namespace FinalProject_BloggingNewsSite.Pages
{
    public class CreateModel : PageModel
    {
        private readonly FinalProject_BloggingNewsSite.Data.FinalProject_BloggingNewsSiteContext _context;

        public CreateModel(FinalProject_BloggingNewsSite.Data.FinalProject_BloggingNewsSiteContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public FinalProject_BloggingNewsSiteModel FinalProject_BloggingNewsSiteModel { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.FinalProject_BloggingNewsSiteModel.Add(FinalProject_BloggingNewsSiteModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject_BloggingNewsSite.Data;
using FinalProject_BloggingNewsSite.Models;

namespace FinalProject_BloggingNewsSite.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly FinalProject_BloggingNewsSite.Data.FinalProject_BloggingNewsSiteContext _context;

        public DeleteModel(FinalProject_BloggingNewsSite.Data.FinalProject_BloggingNewsSiteContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FinalProject_BloggingNewsSiteModel FinalProject_BloggingNewsSiteModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FinalProject_BloggingNewsSiteModel = await _context.FinalProject_BloggingNewsSiteModel.FirstOrDefaultAsync(m => m.ItemID == id);

            if (FinalProject_BloggingNewsSiteModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FinalProject_BloggingNewsSiteModel = await _context.FinalProject_BloggingNewsSiteModel.FindAsync(id);

            if (FinalProject_BloggingNewsSiteModel != null)
            {
                _context.FinalProject_BloggingNewsSiteModel.Remove(FinalProject_BloggingNewsSiteModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

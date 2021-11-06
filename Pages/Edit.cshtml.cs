using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject_BloggingNewsSite.Data;
using FinalProject_BloggingNewsSite.Models;

namespace FinalProject_BloggingNewsSite.Pages
{
    public class EditModel : PageModel
    {
        private readonly FinalProject_BloggingNewsSite.Data.FinalProject_BloggingNewsSiteContext _context;

        public EditModel(FinalProject_BloggingNewsSite.Data.FinalProject_BloggingNewsSiteContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(FinalProject_BloggingNewsSiteModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FinalProject_BloggingNewsSiteModelExists(FinalProject_BloggingNewsSiteModel.ItemID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FinalProject_BloggingNewsSiteModelExists(int id)
        {
            return _context.FinalProject_BloggingNewsSiteModel.Any(e => e.ItemID == id);
        }
    }
}

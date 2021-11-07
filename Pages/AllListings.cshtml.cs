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
    public class AllListingsModel : PageModel
    {
        private readonly FinalProject_BloggingNewsSite.Data.FinalProject_BloggingNewsSiteContext _context;

        public AllListingsModel(FinalProject_BloggingNewsSite.Data.FinalProject_BloggingNewsSiteContext context)
        {
            _context = context;
        }

        public IList<FinalProject_BloggingNewsSiteModel> FinalProject_BloggingNewsSiteModel { get;set; }

        public async Task OnGetAsync()
        {
            FinalProject_BloggingNewsSiteModel = await _context.FinalProject_BloggingNewsSiteModel.ToListAsync();
        }
    }
}

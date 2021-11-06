using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject_BloggingNewsSite.Models;

namespace FinalProject_BloggingNewsSite.Data
{
    public class FinalProject_BloggingNewsSiteContext : DbContext
    {
        public FinalProject_BloggingNewsSiteContext (DbContextOptions<FinalProject_BloggingNewsSiteContext> options)
            : base(options)
        {
        }

        public DbSet<FinalProject_BloggingNewsSite.Models.FinalProject_BloggingNewsSiteModel> FinalProject_BloggingNewsSiteModel { get; set; }
    }
}

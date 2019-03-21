using System;
using Microsoft.EntityFrameworkCore;
using SamplWebApp.Model;

namespace SamplWebApp.Context
{
    public class DaysContext : DbContext
    {
        public DaysContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Days> Days { get; set; }

    }
}

using MVCProject.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVCProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

}

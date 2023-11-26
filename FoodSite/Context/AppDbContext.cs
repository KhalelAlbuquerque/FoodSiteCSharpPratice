using FoodSite.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodSite.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
    }
}

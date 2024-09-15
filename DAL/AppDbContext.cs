using CentalWebsiteFrontToBack.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace CentalWebsiteFrontToBack.DAL
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Category> Categories { get; set; }
       // public DbSet<Product> Products { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<Home> Homes { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using back4ker4.Models;

namespace back4ker4
{
    public class AppDBContent : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDBContent(DbContextOptions<AppDBContent> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

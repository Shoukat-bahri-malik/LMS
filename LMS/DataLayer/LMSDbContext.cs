using LMS.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace LMS.DataLayer
{
    public class LMSDbContext : DbContext
    {
        public LMSDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book>  Books { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

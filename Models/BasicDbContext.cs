using _1_BasicWebApi.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace _1_BasicWebApi.Models
{
    public class BasicDbContext : DbContext
    {
        public BasicDbContext(DbContextOptions<BasicDbContext> options)
        : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
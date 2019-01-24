using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;

namespace WeddingPlanner.Data
{
    public class WeddingContext : DbContext
    {
        public WeddingContext (DbContextOptions options) : base (options) { }
        public DbSet<WeddingUser> Users { get; set; }
        public DbSet<Wedding> Weddings { get; set; }
        public DbSet<Response> Responses { get; set; }
    }
}
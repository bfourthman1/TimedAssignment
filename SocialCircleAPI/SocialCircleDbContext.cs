using Microsoft.EntityFrameworkCore;

namespace SocialCircleAPI
{
    public class SocialCircleDbContext : DbContext
    {
        public SocialCircleDbContext(DbContextOptions<SocialCircleDbContext> options) : base(options) { }
        // public DbSet<Post> Post { get; set; }
    }
}
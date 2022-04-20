using Microsoft.EntityFrameworkCore;
using SocialCircle.Models;

namespace SocialCircleAPI
{
    public class SocialCircleDbContext : DbContext
    {
        public SocialCircleDbContext(DbContextOptions<SocialCircleDbContext> options) : base(options) { }
        public DbSet<Post> Post { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using Sukuna.Common.Models;

namespace Sukuna.DataAccess
{
    public class ArticleDbContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public ArticleDbContext(DbContextOptions options) : base(options)
        {
        }

        /// onm dans genérer les substitution

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

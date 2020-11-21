using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticlePost.Models
{
    public class ArticleContext: DbContext
    {
        public ArticleContext(DbContextOptions<ArticleContext> options):base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=.;Database=ArticleContext;Trusted_Connection=True;");
        }

        public DbSet<User> User { get; set; }
        public DbSet<Article> Article { get; set; }
        public DbSet<UserPermission> UserPermission { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<CommentAndLike> CommentAndLike { get; set; }
        public DbSet<Category> Category { get; set; }


    }
}

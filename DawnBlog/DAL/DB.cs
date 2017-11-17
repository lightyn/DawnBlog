using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DawnBlog.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DawnBlog.DAL
{
    public class DB : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<BlogPostComment> BlogPostComment { get; set; }
        public DbSet<PasswordHash> PasswordHashes { get; set; }

        public DB() : base("DB")
        {
            Database.SetInitializer<DB>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer<DB>(new DropCreateDatabaseIfModelChanges<DB>());
        }
    }
}
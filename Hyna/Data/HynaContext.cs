using System;
using Microsoft.EntityFrameworkCore;
using Hyna.Models;
namespace Hyna.Data
{
    public class HynaContext:DbContext
    {
        public HynaContext(DbContextOptions options):base(options)
        {
        }

        #region Frontend
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectCategory> ProjectCategories { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Fact> Facts { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<FaqCategory> FaqCategories { get; set; }
        #endregion

        #region Seo
        public DbSet<Meta> Metas { get; set; }
        #endregion
    }
}

using System;

using Microsoft.EntityFrameworkCore;

using OhanaSupport.Models;
using OhanaSupport.Enumerators;
using OhanaSupport.Seeders;

namespace OhanaSupport {
    public class ApplicationDbContext: DbContext {
        public DbSet<Link> Links { get; set; }
        public DbSet<LinkTag> LinkTags { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            //Configure LinkTag Primary Key as composite of Foreign Key properties
            modelBuilder.Entity<LinkTag>().HasKey(linkTag => new { linkTag.LinkId, linkTag.TagId });

            //Configure many to many relationship between Links and Tags using LinkTags
            modelBuilder.Entity<Link>().HasMany(link => link.LinkTags).WithOne(linkTag => linkTag.Link);
            modelBuilder.Entity<Tag>().HasMany(tag => tag.LinkTags).WithOne(linkTag => linkTag.Tag);

            //Finish base class model setup
            base.OnModelCreating(modelBuilder);

            //Seed Database
            SeedDatabase(modelBuilder);
        }

        private void SeedDatabase(ModelBuilder modelBuilder) {
            //Create Seeder Objects
            LinkSeeder ls = new LinkSeeder();
            TagSeeder ts = new TagSeeder();
            LinkTagSeeder lts = new LinkTagSeeder();

            //Seed
            ls.Seed(modelBuilder);
            ts.Seed(modelBuilder);
            lts.Seed(modelBuilder);
        }
    }
}
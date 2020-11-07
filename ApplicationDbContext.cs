using System;

using Microsoft.EntityFrameworkCore;

namespace OhanaSupport {
    public class ApplicationDbContext: DbContext {
        //public DbSet<Link> Links { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
        }
    }
}
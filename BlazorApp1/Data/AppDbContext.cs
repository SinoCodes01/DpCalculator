using Microsoft.EntityFrameworkCore;
using BlazorApp1.Models; 

namespace BlazorApp1.Data 
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Module> Modules { get; set; }
        public DbSet<Assessment> Assessments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assessment>()
                .HasOne(a => a.Module)
                .WithMany(m => m.Assessments)
                .HasForeignKey(a => a.ModuleId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
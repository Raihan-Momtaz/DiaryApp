using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry 
                {
                    Id = 1,
                    Title = "Went Hiking",
                    Content = "Went hiking with Julia!",
                    Created = new DateTime(2025, 9, 5, 10, 0, 0)
                },
                new DiaryEntry 
                {
                    Id = 2,
                    Title = "Went Shopping",
                    Content = "Went shopping with Lisa!",
                    Created = new DateTime(2025, 9, 5, 12, 0, 0)
                },
                new DiaryEntry 
                {
                    Id = 3,
                    Title = "Went Diving",
                    Content = "Went diving with Sophie!",
                    Created = new DateTime(2025, 9, 5, 14, 0, 0)
                }
            );
        }

    }
}
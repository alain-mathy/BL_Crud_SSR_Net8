using BL_Crud_SSR_Net8.Entities;
using Microsoft.EntityFrameworkCore;

namespace BL_Crud_SSR_Net8.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                
                new Game { Id = 1, Title = "T1", Publisher = "P1", ReleaseYear = 2017 },
                new Game { Id = 2, Title = "T2", Publisher = "P2", ReleaseYear = 2018 },
                new Game { Id = 3, Title = "T3", Publisher = "P3", ReleaseYear = 2018 }
            );
        }
        public DbSet<Game> Games { get; set; }
    }
}

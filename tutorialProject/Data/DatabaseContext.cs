using Microsoft.EntityFrameworkCore;
using tutorialProject.Models;

namespace tutorialProject.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
       
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Tunisia",
                    ShortName = "TUN"
                },
                new Country
                {
                    Id = 2,
                    Name = "France",
                    ShortName = "FR"
                },
                new Country
                {
                    Id = 3,
                    Name = "Germany",
                    ShortName = "GER"
                }
                );
            builder.Entity<Hotel>().HasData(
               new Hotel
               {
                   Id = 1,
                   Name = "ibis",
                   Address = "rond point manzel chaker centre ville",
                   CountryId = 1,
                   Rating = "4.5",
               },
               new Hotel
               {
                   Id = 2,
                   Name = "ile de france",
                   Address = "la defence 16ème arrondissement",
                   CountryId = 2,
                   Rating = "5",
               },
               new Hotel
               {
                   Id = 3,
                   Name = "frankfurt beach",
                   Address = "frankfurt centre ville kodem chapati mileha",
                   CountryId = 3,
                   Rating = "6",
               }
               );
        }
    }
}

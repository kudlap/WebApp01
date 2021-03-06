using Microsoft.EntityFrameworkCore;

namespace HotelListing01.Data
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
                    Name = "Czech Republic",
                    ShortName = "CZ"
                },
                new Country
                {
                    Id = 2,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id = 3,
                    Name = "Bahamas",
                    ShortName = "BS"
                }
                );


            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Heligonka",
                    Address = "Ostrava",
                    CountryId = 1,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    CountryId = 2,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Palladium",
                    Address = "Nassua",
                    CountryId = 3,
                    Rating = 4.7
                }
                );
        }
    }
}

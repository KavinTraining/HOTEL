using Microsoft.EntityFrameworkCore;

namespace HOTEL.Data
{
    public class HotelListingDbContext: DbContext 
    {
        public HotelListingDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(

                new Country
                {
                    id=1,
                    Name="Jamaica",
                    ShortName="JM"
            },new Country
                {
                  id=2,
                  Name="Bahamas",
                  ShortName="BH"
            },
                new Country
                {
                    id=3,
                    Name="Cayman Island",
                    ShortName="CI"
                }
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    HotelId=1,
                    Name="Sandals Resort and Spa",
                    Address="Negril",
                    CountryID=1,
                    Rating=4.3

                },
                new Hotel
                {
                    HotelId = 2,
                    Name = "Comfort suites",
                    Address = "George Towm",
                    CountryID = 3,
                    Rating = 5
                });
        }
        
    }
}

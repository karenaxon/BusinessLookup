using Microsoft.EntityFrameworkCore;

namespace BusinessLookup.Models
{
    public class BusinessLookupContext : DbContext
    {
        public BusinessLookupContext(DbContextOptions<BusinessLookupContext> options)
            : base(options)
        {
        }

        public DbSet<Business> Businesses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Business>()
            .HasData(
                new Business { BusinessId = 1, Name = "Julio's", Type = "Restaurant", StreetAddress = "123 Street", City = "Bothell", State = "WA", ZipCode = "98021" },
                new Business { BusinessId = 2, Name = "Best Flowers", Type = "Florist", StreetAddress = "Wonderful Street", City = "Bellevue", State = "WA", ZipCode = "98023" },
                new Business { BusinessId = 3, Name = "Shinny Clean", Type = "Dry Cleaner", StreetAddress = "Main Street", City = "Renton", State = "WA", ZipCode = "98025" }
            );
        }
    }
}
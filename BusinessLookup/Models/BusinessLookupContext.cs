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
    }
}
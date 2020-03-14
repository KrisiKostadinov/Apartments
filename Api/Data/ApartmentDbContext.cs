using Apartments.Models;
using Microsoft.EntityFrameworkCore;

namespace Apartments.Data
{
    public class ApartmentDbContext : DbContext
    {
        public ApartmentDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Apartment> Apartments { get; set; }
    }
}

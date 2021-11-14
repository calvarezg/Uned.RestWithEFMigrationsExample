using Microsoft.EntityFrameworkCore;
using Uned.RestWithEFExample.Models;

namespace Uned.RestWithEFExample.Data
{
    public class ApplicationDataContext : DbContext
    {
        public DbSet<Guitar> Guitars { get; set; }
        public DbSet<GuitarHistory> GuitarHistory { get; set; }

        public ApplicationDataContext(DbContextOptions options) : base(options) { }
    }
}

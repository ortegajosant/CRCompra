using CRCompras.Models;
using Microsoft.EntityFrameworkCore;

namespace CRCompras.Persistence
{
    public class CRCompraDBContext : DbContext
    {
        public CRCompraDBContext(DbContextOptions<CRCompraDBContext> options) : base(options)
        {

        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}
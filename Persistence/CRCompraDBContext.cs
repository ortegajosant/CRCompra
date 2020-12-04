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
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Model_car> Models {get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleFeatures>().HasKey(vf => new { vf.VehicleId, vf.FeatureId });
        }
    }
}
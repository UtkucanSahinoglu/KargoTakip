using KargoTakip.DatabaseBuilder;
using Microsoft.EntityFrameworkCore;
using System;

namespace KargoTakip.DBBContext
{
    public class KargoTakipDbContext : DbContext
    {
        public DbSet<Cargo.Cargo> cargos { get; set; }
        public DbSet<CargoTracking.CargoTracking> cargoTrackings { get; set; }
        public DbSet<Cargo.Address> address { get; set; }
        public DbSet<Cargo.City> city { get; set; }
        public DbSet<Cargo.District> district { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
            optionsBuilder.UseMySql("server=localhost;database=KargoDb;user=root;port=3306;password=password", serverVersion);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            CargoDatabaseBuilder.TableBuilder(modelBuilder);
            CargoTrackingDatabaseBuilder.TableBuilder(modelBuilder);
            AddressDatabaseBuilder.TableBuilder(modelBuilder);


        }
    }
}

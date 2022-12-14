using Cargo;
using Microsoft.EntityFrameworkCore;

namespace KargoTakip.DatabaseBuilder
{
    public class AddressDatabaseBuilder
    {
        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name);
                entity.Property(e => e.OpenAddress);
                entity.HasOne(e => e.City).WithMany(e => e.Addresses).HasForeignKey(e => e.CityId);
                entity.HasOne(e => e.District).WithMany(e => e.Addresses).HasForeignKey(e => e.DistrictId);
                //entity.HasMany(e => e.Cargos).WithOne(e => e.Address).HasForeignKey(e => e.Id);                

            });
            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name);

            });
            modelBuilder.Entity<District>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name);
                entity.HasOne(e => e.City).WithMany(e => e.District).HasForeignKey(e => e.CityId);
            });
        }
    }
}

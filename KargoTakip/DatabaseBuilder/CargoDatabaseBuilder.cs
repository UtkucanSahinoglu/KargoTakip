using Microsoft.EntityFrameworkCore;

namespace KargoTakip.DatabaseBuilder
{
    public class CargoDatabaseBuilder
    {
        static void SetDataToDB(ModelBuilder modelBuilder)
        {

        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cargo.Cargo>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.SenderName);
                entity.Property(e => e.RecipientName);
                entity.Property(e => e.TrackingNumber);
                entity.Property(e => e.SenderAddress);
                entity.Property(e => e.RecipientAddress);
                entity.Property(e => e.SendingDate);
                entity.Property(e => e.DeliveryDate);
                entity.HasOne(e => e.Address).WithMany(e => e.Cargos).HasForeignKey(e => e.AddressId);

            });

        }
    }
}

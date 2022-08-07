using Microsoft.EntityFrameworkCore;

namespace KargoTakip.DatabaseBuilder
{
    public class CargoTrackingDatabaseBuilder
    {
        static void SetDataToDB(ModelBuilder modelBuilder)
        {

        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CargoTracking.CargoTracking>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.TrackingNumber);

            });

        }
    }
}

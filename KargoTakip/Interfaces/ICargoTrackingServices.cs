using System.Collections.Generic;
using System.Threading.Tasks;

namespace KargoTakip.Interfaces
{
    public interface ICargoTrackingServices
    {
        Task <CargoTracking.CargoTracking> AddCargoTracking(CargoTracking.CargoTracking cargoTracking);
        Task <IEnumerable<CargoTracking.CargoTracking>> GetByTrackingNumber(string TrackingNumber);
        Task <IEnumerable<CargoTracking.CargoTracking>> GetAllByTrackingNumber();
        Task <CargoTracking.CargoTracking> GetByCargoTrackingId(int Id);


    }
}

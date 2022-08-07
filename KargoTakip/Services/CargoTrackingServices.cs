using KargoTakip.Interfaces;
using KargoTakip.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KargoTakip.Services
{
    public class CargoTrackingServices : ICargoTrackingServices
    {
        private readonly ICargoTrackingRepository _cargoTrackingRepository;

        public CargoTrackingServices(ICargoTrackingRepository cargoTrackingRepository)
        {
            this._cargoTrackingRepository = cargoTrackingRepository;
        }

        public async Task<CargoTracking.CargoTracking> AddCargoTracking(CargoTracking.CargoTracking cargoTracking)
        {
            return await _cargoTrackingRepository.AddCargoTracking(cargoTracking);
        }

        public async Task<IEnumerable<CargoTracking.CargoTracking>> GetAllByTrackingNumber()
        {
            return await _cargoTrackingRepository.GetAllByTrackingNumber();
        }

        public async Task <CargoTracking.CargoTracking> GetByCargoTrackingId(int Id)
        {
            if ( Id ==null)
            {
                throw new System.Exception();
            }
            return await _cargoTrackingRepository.GetByCargoTrackingId(Id);
        }

        public async Task<IEnumerable<CargoTracking.CargoTracking>> GetByTrackingNumber(string TrackingNumber)
        {
            if(TrackingNumber == null)
            {
                throw new System.Exception();
            }
            return await _cargoTrackingRepository.GetByTrackingNumber(TrackingNumber);
        }
    }
}

using KargoTakip.DBBContext;
using KargoTakip.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KargoTakip.Repository
{
    public class CargoTrackingRepository : ICargoTrackingRepository
    {
        private readonly KargoTakipDbContext _kargoTakipDbContext;
        public CargoTrackingRepository(KargoTakipDbContext kargoTakipDbContext)
        {
            this._kargoTakipDbContext = kargoTakipDbContext;
        }

        public async Task<CargoTracking.CargoTracking> AddCargoTracking(CargoTracking.CargoTracking cargoTracking)
        {
            var AddCargoTracking = _kargoTakipDbContext.cargoTrackings.Add(cargoTracking);
            await _kargoTakipDbContext.SaveChangesAsync();
            return cargoTracking;
        }

        public async Task<IEnumerable<CargoTracking.CargoTracking>> GetAllByTrackingNumber()
        {
            return await _kargoTakipDbContext.Set<CargoTracking.CargoTracking>().ToListAsync();
        }

        public async Task<CargoTracking.CargoTracking> GetByCargoTrackingId(int Id)
        {
            return await _kargoTakipDbContext.cargoTrackings.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<CargoTracking.CargoTracking>> GetByTrackingNumber(string TrackingNumber)
        {
            return await _kargoTakipDbContext.cargoTrackings.Where(x => x.TrackingNumber == TrackingNumber).ToListAsync();
        }
    }
}

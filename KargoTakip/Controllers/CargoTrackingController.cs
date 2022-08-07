using KargoTakip.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KargoTakip.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CargoTrackingController : ControllerBase
    {
        private readonly ICargoTrackingServices _cargoTrackingServices;

        public CargoTrackingController(ICargoTrackingServices cargoTrackingServices)
        {
            this._cargoTrackingServices = cargoTrackingServices;
        }

        [HttpPost]
        public async Task<CargoTracking.CargoTracking> AddCargoTracking(CargoTracking.CargoTracking cargoTracking)
        {
            return await _cargoTrackingServices.AddCargoTracking(cargoTracking);
        }
        [HttpGet("TranckingNumber")]
        public async Task<IEnumerable<CargoTracking.CargoTracking>> GetByTrackingNumber(string TrackingNumber)
        {
            return await _cargoTrackingServices.GetByTrackingNumber(TrackingNumber);

        }
        [HttpGet]
        public async Task<IEnumerable<CargoTracking.CargoTracking>> GetAllByTrackingNumber()
        {
            return await _cargoTrackingServices.GetAllByTrackingNumber();
        }
        [HttpGet("Id")]
        public async Task<CargoTracking.CargoTracking> GetByCargoTrackingId(int Id)
        {
            return await _cargoTrackingServices.GetByCargoTrackingId(Id);
        }



    }
}

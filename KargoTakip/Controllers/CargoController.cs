using KargoTakip.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KargoTakip.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CargoController : ControllerBase
    {
        private readonly ICargoServices _cargoServices;
        public CargoController(ICargoServices cargoServices)
        {
            this._cargoServices = cargoServices;
        }

        [HttpPost]
        public Task<Cargo.Cargo> AddCargo(Cargo.Cargo cargo)
        {
            return _cargoServices.AddCargo(cargo);
        }
        [HttpGet("SenderName")]
        public async Task<IEnumerable<Cargo.Cargo>> GetBySenderName(string SenderName)
        {
            return await _cargoServices.GetBySenderName(SenderName);
        }
        [HttpGet("Id")]
        public async Task<Cargo.Cargo> GetById(int Id)
        {
            return await _cargoServices.GetByCargoId(Id);
        }
        [HttpGet("RecipientName")]
        public async Task<IEnumerable<Cargo.Cargo>> GetByRecipientName(string RecipientName)
        {
            return await _cargoServices.GetByRecipientName(RecipientName);
        }
        [HttpGet("SenderAddress")]
        public async Task<IEnumerable<Cargo.Cargo>> GetBySenderAddress(string SenderAddress)
        {
            return await _cargoServices.GetBySenderAddress(SenderAddress);
        }
        [HttpGet("RecipientAddress")]
        public async Task<IEnumerable<Cargo.Cargo>> GetByRecipientAddress(string RecipientAddress)
        {
            return await _cargoServices.GetByRecipientAddress(RecipientAddress);
        }
    }
}

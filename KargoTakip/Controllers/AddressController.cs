using KargoTakip.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KargoTakip.Controllers
{
        [ApiController]
        [Route("[controller]")]
        public class AddressController : ControllerBase
        {
            private readonly IAddressServices _addressServices;
            public AddressController(IAddressServices addressServices)
            {
                this._addressServices = addressServices;
            }
            [HttpPost("AddAddress")]
            public async Task<Cargo.Address> AddAddress(Cargo.Address address)
            {
                return await _addressServices.AddAddress(address);
            }
            [HttpGet("GetAddresses")]
            public async Task<IEnumerable<Cargo.Address>> GetAddresses()
            {
                return await _addressServices.GetAllAddresses();
            }
            [HttpGet("GetByAddressName/{Name}")]
            public async Task<IEnumerable<Cargo.Address>> GetByAddressName(string Name)
            {
                return await _addressServices.GetByAddressName(Name);
            }
            [HttpGet("OpenAddress")]
            public async Task<IEnumerable<Cargo.Address>> GetByOpenAddress(string OpenAddress)
            {
                return await _addressServices.GetByOpenAddress(OpenAddress);
            }
            [HttpGet("GetByAddressId/{Id}")]
            public async Task<Cargo.Address> GetByAddressId(int Id)
            {
                return await _addressServices.GetByAddressId(Id);
            }
            [HttpPost("AddCity")]
            public async Task<Cargo.City> AddCity(Cargo.City city)
            {
                return await _addressServices.AddCity(city);
            }
            [HttpGet("GetByCityName/{Name}")]
            public async Task<IEnumerable<Cargo.City>> GetByCityName(string Name)
            {
                return await _addressServices.GetByCityName(Name);
            }
            [HttpGet("GetAllCity")]
            public Task<IEnumerable<Cargo.City>> GetAllCity()
            {
                return _addressServices.GetAllCity();
            }
            [HttpGet("GetByCityId/{Id}")]
            public async Task<Cargo.City> GetByCityId(int Id)
            {
                return await _addressServices.GetByCityId(Id);
            }
            [HttpPost("AddDistrict")]
            public async Task<Cargo.District> AddDistrict(Cargo.District district)
            {
                return await _addressServices.AddDistrict(district);
            }
            [HttpGet("GetByDistrictName/{Name}")]
            public async Task<IEnumerable<Cargo.District>> GetByDistrictName(string Name)
            {
                return await _addressServices.GetByDistrictName(Name);
            }
            [HttpGet("GetAllDistricts")]
            public async Task<IEnumerable<Cargo.District>> GetAllDistricts()
            {
                return await _addressServices.GetAllDistrict();
            }
            [HttpGet("GetByDistrictId/{Id}")]
            public async Task<Cargo.District> GetByDistrictId(int Id)
            {
                return await _addressServices.GetDistrictId(Id);
            }
        }
}

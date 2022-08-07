using Cargo;
using KargoTakip.Interfaces;
using KargoTakip.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KargoTakip.Services
{
    public class AddressServices : IAddressServices
    {
        private readonly IAddressRepository _addressRepository;
        public AddressServices(IAddressRepository addressRepository)
        {
            this._addressRepository = addressRepository;
        }
        public async Task<Address> AddAddress(Address address)
        {
            return await _addressRepository.AddAddress(address);
        }

        public async Task<City> AddCity(City city)
        {
            return await _addressRepository.AddCity(city);
        }

        public async Task<District> AddDistrict(District district)
        {
            return await _addressRepository.AddDistrict(district);
        }

        public async Task<IEnumerable<Address>> GetAllAddresses()
        {
            return await _addressRepository.GetAllAddresses();
        }

        public async Task<IEnumerable<City>> GetAllCity()
        {
            return await _addressRepository.GetAllCity();
        }

        public async Task<IEnumerable<District>> GetAllDistrict()
        {
            return await _addressRepository.GetAllDistricts();
        }

        public async Task<Address> GetByAddressId(int Id)
        {
            return await _addressRepository.GetByAddressId(Id);
        }

        public async Task<IEnumerable<Address>> GetByAddressName(string Name)
        {
            if(Name == null)
            {
                throw new Exception();
            }
            return await _addressRepository.GetByAddressName(Name);
        }

        public async Task<City> GetByCityId(int Id)
        {
            return await _addressRepository.GetByCityId(Id);
        }

        public async Task<IEnumerable<City>> GetByCityName(string Name)
        {
            if (Name == null)
            {
                throw new Exception();
            }
            return await _addressRepository.GetByCityName(Name);
        }

        public async Task<IEnumerable<District>> GetByDistrictName(string Name)
        {
            if(Name== null)
            {
                throw new Exception();
            }
            return await _addressRepository.GetByDistrictName(Name);
        }

        public async Task<IEnumerable<Address>> GetByOpenAddress(string OpenAddress)
        {
            if( OpenAddress == null)
            {
                throw new Exception();
            }
            return await _addressRepository.GetByOpenAddress(OpenAddress);
        }

        public async Task<District> GetDistrictId(int Id)
        {
            return await _addressRepository.GetByDistrictId(Id);
        }
    }
}

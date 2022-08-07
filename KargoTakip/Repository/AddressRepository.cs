using Cargo;
using KargoTakip.DBBContext;
using KargoTakip.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KargoTakip.Repository
{
    public class AddressRepository : IAddressRepository
    {
        private readonly KargoTakipDbContext _kargoTakipDbContext;
        public AddressRepository(KargoTakipDbContext kargoTakipDbContext)
        {
            this._kargoTakipDbContext = kargoTakipDbContext;
        }
        public async Task<Address> AddAddress(Address address)
        {
            var AddAddress = _kargoTakipDbContext.AddAsync(address);
            await _kargoTakipDbContext.SaveChangesAsync();
            return address;
        }

        public async Task<City> AddCity(City city)
        {
            var AddCity = _kargoTakipDbContext.AddAsync(city);
            await _kargoTakipDbContext.SaveChangesAsync();
            return city;
        }

        public async Task<District> AddDistrict(District district)
        {
            var AddDistrict = _kargoTakipDbContext.AddAsync(district);
            await _kargoTakipDbContext.SaveChangesAsync();
            return district;
        }

        public async Task<IEnumerable<Address>> GetAllAddresses()
        {
            return await _kargoTakipDbContext.address.ToListAsync();
        }

        public async Task<IEnumerable<City>> GetAllCity()
        {
            return await _kargoTakipDbContext.city.ToListAsync();
        }

        public async Task<IEnumerable<District>> GetAllDistricts()
        {
            return await _kargoTakipDbContext.district.ToListAsync();
        }

        public async Task<Address> GetByAddressId(int Id)
        {
            return await _kargoTakipDbContext.address.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Address>> GetByAddressName(string Name)
        {
            return await _kargoTakipDbContext.address.Where(x => x.Name == Name).ToListAsync();
        }

        public async Task<City> GetByCityId(int Id)
        {
            return await _kargoTakipDbContext.city.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<City>> GetByCityName(string Name)
        {
            return await _kargoTakipDbContext.city.Where(x => x.Name == Name).ToListAsync();
        }

        public async Task<District> GetByDistrictId(int Id)
        {
            return await _kargoTakipDbContext.district.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<District>> GetByDistrictName(string Name)
        {
            return await _kargoTakipDbContext.district.Where(x => x.Name == Name).ToListAsync();
        }

        public async Task<IEnumerable<Address>> GetByOpenAddress(string OpenAddress)
        {
            return await _kargoTakipDbContext.address.Where(x => x.OpenAddress == OpenAddress).ToListAsync();
        }
    }
}

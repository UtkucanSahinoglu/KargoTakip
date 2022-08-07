using Cargo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KargoTakip.Interfaces
{
    public interface IAddressRepository
    {
        Task <Cargo.Address> AddAddress(Address address);
        Task <IEnumerable<Cargo.Address>> GetAllAddresses();
        Task <IEnumerable<Cargo.Address>> GetByAddressName(string Name);
        Task <IEnumerable<Cargo.Address>> GetByOpenAddress(string OpenAddress);
        Task <Cargo.Address> GetByAddressId(int Id);
        Task <Cargo.City> AddCity(Cargo.City city);
        Task <IEnumerable<Cargo.City>> GetByCityName(string Name);
        Task <IEnumerable<Cargo.City>> GetAllCity();
        Task <Cargo.City> GetByCityId(int Id);
        Task <Cargo.District> AddDistrict(Cargo.District district);
        Task <IEnumerable<Cargo.District>> GetByDistrictName(string Name);
        Task <IEnumerable <Cargo.District>> GetAllDistricts();
        Task <Cargo.District> GetByDistrictId(int Id);
    }
}

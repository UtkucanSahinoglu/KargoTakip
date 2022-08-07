using KargoTakip.Interfaces;
using KargoTakip.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KargoTakip.Services
{
    public class CargoServices : ICargoServices
    {
        private readonly ICargoRepository _cargoRepository;
        public CargoServices(ICargoRepository cargoRepository)
        {
            this._cargoRepository = cargoRepository;
        }

        public Task<Cargo.Cargo> AddCargo(Cargo.Cargo cargo)
        {
            return _cargoRepository.AddCargo(cargo);
        }

        public async Task<IEnumerable<Cargo.Cargo>> GetAllByCargo()
        {
            return await _cargoRepository.GetAllByCargo();
        }

        public async Task <Cargo.Cargo> GetByCargoId(int Id)
        {

            return await _cargoRepository.GetByCargoId(Id);
        }

        public async Task<IEnumerable<Cargo.Cargo>> GetByRecipientAddress(string RecipientAddress)
        {
            if (RecipientAddress == null)
            {
                throw new Exception();
            }
            return await _cargoRepository.GetByRecipientAddress(RecipientAddress);
        }

        public async Task<IEnumerable<Cargo.Cargo>> GetByRecipientName(string RecipientName)
        {
            if (RecipientName == null)
            {
                throw new Exception();
            }
            return await _cargoRepository.GetByRecipientName(RecipientName);
        }

        public async Task<IEnumerable<Cargo.Cargo>> GetBySenderAddress(string SenderAddress)
        {
            if(SenderAddress == null)
            {
                throw new Exception();
            }
            return await _cargoRepository.GetBySenderAddress(SenderAddress);
        }

        public async Task<IEnumerable<Cargo.Cargo>> GetBySenderName(string SenderName)
        {
            if (SenderName == null)
            {
                throw new Exception();
            }
            return await _cargoRepository.GetBySenderName(SenderName);
        }
    }
}

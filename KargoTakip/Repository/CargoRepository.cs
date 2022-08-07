using KargoTakip.DBBContext;
using KargoTakip.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KargoTakip.Repository
{
    public class CargoRepository : ICargoRepository
    {
        private readonly KargoTakipDbContext _kargoTakipDbContext;
        public CargoRepository(KargoTakipDbContext kargoTakipDbContext)
        {
            this._kargoTakipDbContext = kargoTakipDbContext;
        }

        public async Task<Cargo.Cargo> AddCargo(Cargo.Cargo cargo)
        {
            var addCargo = _kargoTakipDbContext.AddAsync(cargo);
            await _kargoTakipDbContext.SaveChangesAsync();
            return cargo;
        }

        public async Task<IEnumerable<Cargo.Cargo>> GetAllByCargo()
        {
            return await _kargoTakipDbContext.Set<Cargo.Cargo>().ToListAsync();
        }

        public async Task <Cargo.Cargo> GetByCargoId(int Id)
        {
            return await _kargoTakipDbContext.Set<Cargo.Cargo>().Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Cargo.Cargo>> GetByRecipientAddress(string RecipientAddress)
        {
            return await _kargoTakipDbContext.cargos.Where(x => x.RecipientAddress == RecipientAddress).ToListAsync();
        }

        public async Task<IEnumerable<Cargo.Cargo>> GetByRecipientName(string RecipientName)
        {
            return await _kargoTakipDbContext.cargos.Where(x => x.RecipientName == RecipientName).ToListAsync();
        }

        public async Task<IEnumerable<Cargo.Cargo>> GetBySenderAddress(string SenderAddress)
        {
            return await _kargoTakipDbContext.cargos.Where(x => x.SenderAddress == SenderAddress).ToListAsync();
        }

        public async Task<IEnumerable<Cargo.Cargo>> GetBySenderName(string SenderName)
        {
            return await _kargoTakipDbContext.cargos.Where(x => x.SenderName == SenderName).ToListAsync();
        }
    }
}

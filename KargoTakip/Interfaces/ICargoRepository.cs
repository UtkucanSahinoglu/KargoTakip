using System.Collections.Generic;
using System.Threading.Tasks;

namespace KargoTakip.Interfaces
{
    public interface ICargoRepository
    {
        Task <Cargo.Cargo> AddCargo(Cargo.Cargo cargo);
        Task<IEnumerable<Cargo.Cargo>> GetAllByCargo();
        Task<Cargo.Cargo> GetByCargoId(int Id);
        Task<IEnumerable<Cargo.Cargo>> GetBySenderName(string SenderName);
        Task <IEnumerable<Cargo.Cargo>> GetByRecipientName(string RecipientName);
        Task <IEnumerable<Cargo.Cargo>> GetBySenderAddress(string SenderAddress);
        Task <IEnumerable<Cargo.Cargo>> GetByRecipientAddress(string RecipientAddress);
    }
}

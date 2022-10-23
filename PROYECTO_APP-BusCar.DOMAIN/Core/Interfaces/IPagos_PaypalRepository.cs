using PROYECTO_APP_BusCar.DOMAIN.Infrastructure.Data;

namespace PROYECTO_APP_BusCar.DOMAIN.Core.Interfaces
{
    public interface IPagos_PaypalRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<PagosPaypal>> GetPagosPaypal();
        Task<bool> Insert(PagosPaypal PagosPaypal);
        Task<PagosPaypal> PagosPaypal(int id);
        Task<bool> Update(PagosPaypal PagosPaypal);
    }
}
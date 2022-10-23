using PROYECTO_APP_BusCar.DOMAIN.Core.Entities;

namespace PROYECTO_APP_BusCar.DOMAIN.Core.Interfaces
{
    public interface IAsientoProgramacionRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<AsientoProgramacion>> GetAsientoProgramacion();
        Task<AsientoProgramacion> GetAsientoProgramacion(int id);
        Task<bool> Insert(Asiento asiento);
        Task<bool> Update(Asiento asiento);
    }
}
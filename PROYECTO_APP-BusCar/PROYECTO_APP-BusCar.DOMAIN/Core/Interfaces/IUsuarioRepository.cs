using PROYECTO_APP_BusCar.DOMAIN.Core.Entities;

namespace PROYECTO_APP_BusCar.DOMAIN.Core.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<bool> Delete(int id);
        Task<Usuario> GetUsuario(int id);
        Task<IEnumerable<Usuario>> GetUsuarios();
        Task<bool> Insert(Usuario usuario);
        Task<bool> Update(Usuario usuario);
    }
}
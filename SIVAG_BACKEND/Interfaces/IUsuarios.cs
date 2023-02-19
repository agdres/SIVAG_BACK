using SIVAG_BACKEND.Interfaces.General;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Interfaces
{
    public interface IUsuarios : IEntityRep<UsuariosDTO>
    {
        Task<List<UsuariosDTO>> GetAll_Sucursal(int Sucursal);
        Task<bool> VerificarPass(int Usuario, string Pass);
    }
}

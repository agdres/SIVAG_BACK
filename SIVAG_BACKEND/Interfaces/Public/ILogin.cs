using SIVAG_BACKEND.Models.API_Response.Public;

namespace SIVAG_BACKEND.Interfaces.Public
{
    public interface ILogin
    {
        Task<LoginRes> ValidarIngreso(string usuario,string clave);
    }
}

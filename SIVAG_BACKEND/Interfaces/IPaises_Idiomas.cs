using SIVAG_BACKEND.Interfaces.General;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Interfaces
{
    public interface IPaises_Idiomas : IEntityRep<Paises_IdiomasDTO>
    {
        Task<List<Paises_IdiomasDTO>> GetAll_Pais(int Pais);
        Task<List<Paises_IdiomasDTO>> GetPaises_IdiomasActivos(int Pais);
    }
}

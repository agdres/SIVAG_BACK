using SIVAG_BACKEND.Interfaces.General;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Interfaces
{
    public interface IMonedas_Paises : IEntityRep<Monedas_PaisesDTO>
    {
        Task<List<Monedas_PaisesDTO>> GetAll_Pais(int Pais);
        Task<List<Monedas_PaisesDTO>> GetMonedas_PaisesActivos(int Pais);
    }
}

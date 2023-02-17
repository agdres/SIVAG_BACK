using SIVAG_BACKEND.Interfaces.General;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Interfaces
{
    public interface IDepartamentos:IEntityRep<DepartamentosDTO>
    {
        Task<List<DepartamentosDTO>> GetDepartamentosActivos(int Pais);

    }
}

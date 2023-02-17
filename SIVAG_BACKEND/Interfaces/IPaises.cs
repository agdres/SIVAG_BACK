using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Interfaces.General;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Interfaces
{
    public interface IPaises : IEntityRep<PaisesDTO>
    {
        Task<List<PaisesDTO>> GetPaisesActivos();
    }
}

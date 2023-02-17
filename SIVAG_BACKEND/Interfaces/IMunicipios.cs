using SIVAG_BACKEND.Interfaces.General;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Interfaces
{
    public interface IMunicipios : IEntityRep<MunicipiosDTO>
    {
        Task<List<MunicipiosDTO>> GetMunicipiosActivos(int Departamento);
    }
}

using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Interfaces.General;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Interfaces
{
    public interface ITipos_Documentos : IEntityRep<Tipos_DocumentosDTO>
    {
        Task<List<Tipos_DocumentosDTO>> GetTipDocActivos();
    }

}

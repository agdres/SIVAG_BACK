using SIVAG_BACKEND.Interfaces.General;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Interfaces
{
    public interface IMedios_Pago : IEntityRep<Medios_PagoDTO>
    {
        Task<List<Medios_PagoDTO>> GetFormasPagosActivos();
    }
}

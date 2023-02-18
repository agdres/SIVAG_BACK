using SIVAG_BACKEND.Interfaces.General;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Interfaces
{
    public interface IFormas_Pago : IEntityRep<Formas_PagoDTO>
    {
        Task<List<Formas_PagoDTO>> GetFormasPagosActivos();
    }
}

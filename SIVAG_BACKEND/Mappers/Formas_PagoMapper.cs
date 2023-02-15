using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class Formas_PagoMapper
    {
        public static Formas_PagoDTO ToFormas_PagoDTO(this Formas_PagoDomain formasPago)
        {
            return new Formas_PagoDTO
            {
                Forma_Pago = formasPago.Forma_Pago,
                Descripcion = formasPago.Descripcion,
                Estado = formasPago.Estado
            };
        } 
        public static Formas_PagoDomain ToFormas_PagoDomain(this Formas_PagoDTO formasPago)
        {
            return new Formas_PagoDomain
            {
                Forma_Pago = formasPago.Forma_Pago,
                Descripcion = formasPago.Descripcion,
                Estado = formasPago.Estado
            };
        }
    }
}

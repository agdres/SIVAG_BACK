using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class Medios_PagoMapper
    {
        public static Medios_PagoDTO ToMedios_PagoDTO(this Medios_PagoDomain formasPago)
        {
            return new Medios_PagoDTO
            {
                Medio_Pago = formasPago.Medio_Pago,
                Descripcion = formasPago.Descripcion,
                Estado = formasPago.Estado
            };
        }
        public static Medios_PagoDomain ToMedios_PagoDomain(this Medios_PagoDTO formasPago)
        {
            return new Medios_PagoDomain
            {
                Medio_Pago = formasPago.Medio_Pago,
                Descripcion = formasPago.Descripcion,
                Estado = formasPago.Estado
            };
        }
    }
}

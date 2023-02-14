using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class MonedasMapper
    {
        public static MonedasDTO ToMonedasDTO(this MonedasDomain monedas)
        {
            return new MonedasDTO
            {
                Moneda = monedas.Moneda,
                Descripcion = monedas.Descripcion,
                Simbolo = monedas.Simbolo,
                Codigo = monedas.Codigo,
                Estado = monedas.Estado
            };
        } 
        public static MonedasDomain ToMonedasDomain(this MonedasDTO monedas)
        {
            return new MonedasDomain
            {
                Moneda = monedas.Moneda,
                Descripcion = monedas.Descripcion,
                Simbolo = monedas.Simbolo,
                Codigo = monedas.Codigo,
                Estado = monedas.Estado
            };
        }
    }
}

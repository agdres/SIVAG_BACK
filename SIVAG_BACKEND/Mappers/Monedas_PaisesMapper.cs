using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class Monedas_PaisesMapper
    {
        public static Monedas_PaisesDTO ToMonedas_PaisesDTO(this Monedas_PaisesDomain monedasPaises)
        {
            return new Monedas_PaisesDTO
            {
                Moneda_Pais = monedasPaises.Moneda_Pais,
                ID_Moneda = monedasPaises.ID_Moneda,
                ID_Pais = monedasPaises.ID_Pais,
                Estado = monedasPaises.Estado
            };
        }        
        public static Monedas_PaisesDomain ToMonedas_PaisesDomain(this Monedas_PaisesDTO monedasPaises)
        {
            return new Monedas_PaisesDomain
            {
                Moneda_Pais = monedasPaises.Moneda_Pais,
                ID_Moneda = monedasPaises.ID_Moneda,
                ID_Pais = monedasPaises.ID_Pais,
                Estado = monedasPaises.Estado
            };
        }
    }
}

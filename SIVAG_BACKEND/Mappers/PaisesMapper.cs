using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class PaisesMapper
    {
        public static PaisesDTO ToPaisesDTO(this PaisesDomain pais)
        {
            return new PaisesDTO
            {
                Pais = pais.Pais,
                Descripcion = pais.Descripcion,
                Alfa_2 = pais.Alfa_2,
                Alfa_3 = pais.Alfa_3,
                Codigo = pais.Codigo,
                Estado = pais.Estado
            };
        }
        public static PaisesDomain ToPaisesDomain(this PaisesDTO pais)
        {
            return new PaisesDomain
            {
                Pais = pais.Pais,
                Descripcion = pais.Descripcion,
                Alfa_2 = pais.Alfa_2,
                Alfa_3 = pais.Alfa_3,
                Codigo = pais.Codigo,
                Estado = pais.Estado
            };
        }
    }
}

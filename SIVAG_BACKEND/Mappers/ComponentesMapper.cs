using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class ComponentesMapper
    {
        public static ComponentesDTO ToComponentesDTO(this ComponentesDomain componente)
        {
            return new ComponentesDTO
            {
                Componente = componente.Componente,
                Descripcion = componente.Descripcion,
                Estado = componente.Estado
            };
        }
        public static ComponentesDomain ToComponentesDomain(this ComponentesDTO componente)
        {
            return new ComponentesDomain
            {
                Componente = componente.Componente,
                Descripcion = componente.Descripcion,
                Estado = componente.Estado
            };
        }
    }
}

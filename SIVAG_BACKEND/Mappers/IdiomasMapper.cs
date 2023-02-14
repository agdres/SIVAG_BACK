using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class IdiomasMapper
    {
        public static IdiomasDTO ToIdiomasDTO(this IdiomasDomain idiomas)
        {
            return new IdiomasDTO
            {
                Idioma = idiomas.Idioma,
                Descripcion = idiomas.Descripcion,
                ISO_639_1 = idiomas.ISO_639_1,
                ISO_639_2 = idiomas.ISO_639_2,
                Estado = idiomas.Estado
            };
        }        
        public static IdiomasDomain ToIdiomasDomain(this IdiomasDTO idiomas)
        {
            return new IdiomasDomain
            {
                Idioma = idiomas.Idioma,
                Descripcion = idiomas.Descripcion,
                ISO_639_1 = idiomas.ISO_639_1,
                ISO_639_2 = idiomas.ISO_639_2,
                Estado = idiomas.Estado
            };
        }
    }
}

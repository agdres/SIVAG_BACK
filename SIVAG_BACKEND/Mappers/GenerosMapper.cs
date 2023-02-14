using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class GenerosMapper
    {
        public static GenerosDTO ToGenerosDTO(this GenerosDomain generos)
        {
            return new GenerosDTO
            {
                Genero = generos.Genero,
                Descripcion = generos.Descripcion,
                Abreviatura = generos.Abreviatura,
                Estado = generos.Estado
            };
        }   
        public static GenerosDomain ToGenerosDomain(this GenerosDTO generos)
        {
            return new GenerosDomain
            {
                Genero = generos.Genero,
                Descripcion = generos.Descripcion,
                Abreviatura = generos.Abreviatura,
                Estado = generos.Estado
            };
        }
    }
}

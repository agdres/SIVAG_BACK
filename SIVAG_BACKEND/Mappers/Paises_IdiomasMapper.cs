using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class Paises_IdiomasMapper
    {
        public static Paises_IdiomasDTO ToPaises_IdiomasDTO(this Paises_IdiomasDomain paisesIdiomas)
        {
            return new Paises_IdiomasDTO
            {
                Pais_Idioma = paisesIdiomas.Pais_Idioma,
                ID_Pais = paisesIdiomas.ID_Pais,
                ID_Idioma = paisesIdiomas.ID_Idioma,
                Estado = paisesIdiomas.Estado
            };
        }      
        public static Paises_IdiomasDomain ToPaises_IdiomasDomain(this Paises_IdiomasDTO paisesIdiomas)
        {
            return new Paises_IdiomasDomain
            {
                Pais_Idioma = paisesIdiomas.Pais_Idioma,
                ID_Pais = paisesIdiomas.ID_Pais,
                ID_Idioma = paisesIdiomas.ID_Idioma,
                Estado = paisesIdiomas.Estado
            };
        }
    }
}

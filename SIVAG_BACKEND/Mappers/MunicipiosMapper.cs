using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class MunicipiosMapper
    {
        public static MunicipiosDTO ToMunicipiosDTO(this MunicipiosDomain municipios)
        {
            return new MunicipiosDTO
            {
                Municipio = municipios.Municipio,
                ID_Departamento = municipios.ID_Departamento,
                Descripcion = municipios.Descripcion,
                Zonapostal = municipios.Zonapostal,
                Codigo = municipios.Codigo,
                Estado = municipios.Estado
            };
        }     
        public static MunicipiosDomain ToMunicipiosDomain(this MunicipiosDTO municipios)
        {
            return new MunicipiosDomain
            {
                Municipio = municipios.Municipio,
                ID_Departamento = municipios.ID_Departamento,
                Descripcion = municipios.Descripcion,
                Zonapostal = municipios.Zonapostal,
                Codigo = municipios.Codigo,
                Estado = municipios.Estado
            };
        }
    }
}

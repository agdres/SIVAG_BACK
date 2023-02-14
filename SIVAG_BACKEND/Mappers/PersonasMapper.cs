using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class PersonasMapper
    {
        public static PersonasDTO ToPersonasDTO(this PersonasDomain persona)
        {
            return new PersonasDTO
            {
                Persona = persona.Persona,
                ID_Tipo_Documento = persona.ID_Tipo_Documento,
                ID_Municipio = persona.ID_Municipio,
                ID_Regimen_Fiscal = persona.ID_Regimen_Fiscal,
                Numero_Documento = persona.Numero_Documento,
                DV = persona.DV,
                Nombre_Empresa = persona.Nombre_Empresa,
                Nombre_Comercial = persona.Nombre_Comercial,
                Primer_Nombre = persona.Primer_Nombre,
                Segundo_Nombre = persona.Segundo_Nombre,
                Primer_Apellido = persona.Primer_Apellido,
                Segundo_Apellido = persona.Segundo_Apellido,
                Fecha_Registro = persona.Fecha_Registro,
                Cliente = persona.Cliente,
                Estado = persona.Estado
            };
        }
        public static PersonasDomain ToPersonasDomain(this PersonasDTO persona)
        {
            return new PersonasDomain
            {
                Persona = persona.Persona,
                ID_Tipo_Documento = persona.ID_Tipo_Documento,
                ID_Municipio = persona.ID_Municipio,
                ID_Regimen_Fiscal = persona.ID_Regimen_Fiscal,
                Numero_Documento = persona.Numero_Documento,
                DV = persona.DV,
                Nombre_Empresa = persona.Nombre_Empresa,
                Nombre_Comercial = persona.Nombre_Comercial,
                Primer_Nombre = persona.Primer_Nombre,
                Segundo_Nombre = persona.Segundo_Nombre,
                Primer_Apellido = persona.Primer_Apellido,
                Segundo_Apellido = persona.Segundo_Apellido,
                Fecha_Registro = persona.Fecha_Registro,
                Cliente = persona.Cliente,
                Estado = persona.Estado
            };
        }
    }
}

using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class Personas_ResponsabilidadesMapper
    {
        public static Personas_ResponsabilidadesDTO ToPersonas_ResponsabilidadesDTO(this Personas_ResponsabilidadesDomain personasResponsabilidades)
        {
            return new Personas_ResponsabilidadesDTO
            {
                Persona_Responsabilidad = personasResponsabilidades.Persona_Responsabilidad,
                ID_Persona = personasResponsabilidades.ID_Persona,
                ID_Responsabilidad_Fiscal = personasResponsabilidades.ID_Responsabilidad_Fiscal,
                Estado = personasResponsabilidades.Estado
            };
        }
        public static Personas_ResponsabilidadesDomain ToPersonas_ResponsabilidadesDomain(this Personas_ResponsabilidadesDTO personasResponsabilidades)
        {
            return new Personas_ResponsabilidadesDomain
            {
                Persona_Responsabilidad = personasResponsabilidades.Persona_Responsabilidad,
                ID_Persona = personasResponsabilidades.ID_Persona,
                ID_Responsabilidad_Fiscal = personasResponsabilidades.ID_Responsabilidad_Fiscal,
                Estado = personasResponsabilidades.Estado
            };
        }
    }
}

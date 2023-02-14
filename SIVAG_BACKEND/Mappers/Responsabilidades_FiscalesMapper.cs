using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class Responsabilidades_FiscalesmAPPER
    {
        public static Responsabilidades_FiscalesDTO ToResponsabilidades_FiscalesDTO(this Responsabilidades_FiscalesDomain responsabilidadesFiscales)
        {
            return new Responsabilidades_FiscalesDTO
            {
                Responsabilidad_Fiscal = responsabilidadesFiscales.Responsabilidad_Fiscal,
                Descripcion = responsabilidadesFiscales.Descripcion,
                Codigo = responsabilidadesFiscales.Codigo,
                Estado = responsabilidadesFiscales.Estado
            };
        }

        public static Responsabilidades_FiscalesDomain ToResponsabilidades_FiscalesDomain(this Responsabilidades_FiscalesDTO responsabilidadesFiscales)
        {
            return new Responsabilidades_FiscalesDomain
            {
                Responsabilidad_Fiscal = responsabilidadesFiscales.Responsabilidad_Fiscal,
                Descripcion = responsabilidadesFiscales.Descripcion,
                Codigo = responsabilidadesFiscales.Codigo,
                Estado = responsabilidadesFiscales.Estado
            };
        }
    }
}

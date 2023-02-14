using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class Regimen_FiscalesMapper
    {
        public static Regimen_FiscalesDTO ToRegimen_FiscalesDTO(this Regimen_FiscalesDomain regimenFiscales)
        {
            return new Regimen_FiscalesDTO
            {
                RegimenFiscal = regimenFiscales.RegimenFiscal,
                Descripcion = regimenFiscales.Descripcion,
                Estado = regimenFiscales.Estado
            };
        }
        public static Regimen_FiscalesDomain ToRegimen_FiscalesDomain(this Regimen_FiscalesDTO regimenFiscales)
        {
            return new Regimen_FiscalesDomain
            {
                RegimenFiscal = regimenFiscales.RegimenFiscal,
                Descripcion = regimenFiscales.Descripcion,
                Estado = regimenFiscales.Estado
            };
        }
    }
}

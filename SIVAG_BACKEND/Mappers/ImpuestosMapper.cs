using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class ImpuestosMapper
    {
        public static ImpuestosDTO ToImpuestosDTO(this ImpuestosDomain impuestos)
        {
            return new ImpuestosDTO
            {
                Impuesto = impuestos.Impuesto,
                ID_Empresa = impuestos.ID_Empresa,
                Descripcion = impuestos.Descripcion,
                Fecha_Implementacion = impuestos.Fecha_Implementacion,
                Estado = impuestos.Estado
            };
        }  
        public static ImpuestosDomain ToImpuestosDomain(this ImpuestosDTO impuestos)
        {
            return new ImpuestosDomain
            {
                Impuesto = impuestos.Impuesto,
                ID_Empresa = impuestos.ID_Empresa,
                Descripcion = impuestos.Descripcion,
                Fecha_Implementacion = impuestos.Fecha_Implementacion,
                Estado = impuestos.Estado
            };
        }
    }
}

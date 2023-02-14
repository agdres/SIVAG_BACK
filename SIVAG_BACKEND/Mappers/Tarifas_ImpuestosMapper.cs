using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class Tarifas_ImpuestosMapper
    {
        public static Tarifas_ImpuestosDTO ToTarifasImpuestosDTO(this Tarifas_ImpuestosDomain tarifasImpuestos)
        {
            return new Tarifas_ImpuestosDTO
            {
                Tarifa_Impuesto = tarifasImpuestos.Tarifa_Impuesto,
                ID_Impuesto = tarifasImpuestos.ID_Impuesto,
                Codigo = tarifasImpuestos.Codigo,
                Descripcion = tarifasImpuestos.Descripcion,
                Valor = tarifasImpuestos.Valor,
                Maximo = tarifasImpuestos.Maximo,
                Minimo = tarifasImpuestos.Minimo,
                Estado = tarifasImpuestos.Estado
            };
        }

        public static Tarifas_ImpuestosDomain ToTarifasImpuestosDomain(this Tarifas_ImpuestosDTO tarifasImpuestos)
        {
            return new Tarifas_ImpuestosDomain
            {
                Tarifa_Impuesto = tarifasImpuestos.Tarifa_Impuesto,
                ID_Impuesto = tarifasImpuestos.ID_Impuesto,
                Codigo = tarifasImpuestos.Codigo,
                Descripcion = tarifasImpuestos.Descripcion,
                Valor = tarifasImpuestos.Valor,
                Maximo = tarifasImpuestos.Maximo,
                Minimo = tarifasImpuestos.Minimo,
                Estado = tarifasImpuestos.Estado
            };
        }
    }
}

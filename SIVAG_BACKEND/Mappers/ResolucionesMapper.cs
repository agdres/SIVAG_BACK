using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class ResolucionesMapper
    {
        public static ResolucionesDTO ToResolucionesDTO(this ResolucionesDomain resoluciones)
        {
            return new ResolucionesDTO
            {
                Resolucion = resoluciones.Resolucion,
                ID_Sucursal = resoluciones.ID_Sucursal,
                Autorizacion = resoluciones.Autorizacion,
                Fecha_Registro = resoluciones.Fecha_Registro,
                Fecha_Expiracion = resoluciones.Fecha_Expiracion,
                Clave = resoluciones.Clave,
                Prefijo = resoluciones.Prefijo,
                Ran_Minimo = resoluciones.Ran_Minimo,
                Ran_Maximo = resoluciones.Ran_Maximo,
                Consecutivo = resoluciones.Consecutivo,
                Fecha_Creacion = resoluciones.Fecha_Creacion,
                Fecha_Inactivacion = resoluciones.Fecha_Inactivacion,
                Estado = resoluciones.Estado
            };
        }
        public static ResolucionesDomain ToResolucionesDomain(this ResolucionesDTO resoluciones)
        {
            return new ResolucionesDomain
            {
                Resolucion = resoluciones.Resolucion,
                ID_Sucursal = resoluciones.ID_Sucursal,
                Autorizacion = resoluciones.Autorizacion,
                Fecha_Registro = resoluciones.Fecha_Registro,
                Fecha_Expiracion = resoluciones.Fecha_Expiracion,
                Clave = resoluciones.Clave,
                Prefijo = resoluciones.Prefijo,
                Ran_Minimo = resoluciones.Ran_Minimo,
                Ran_Maximo = resoluciones.Ran_Maximo,
                Consecutivo = resoluciones.Consecutivo,
                Fecha_Creacion = resoluciones.Fecha_Creacion,
                Fecha_Inactivacion = resoluciones.Fecha_Inactivacion,
                Estado = resoluciones.Estado
            };
        }
    }
}

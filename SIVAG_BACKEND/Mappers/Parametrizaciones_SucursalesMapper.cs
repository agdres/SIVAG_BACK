using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class Parametrizaciones_SucursalesMapper
    {
        public static Parametrizaciones_SucursalesDTO ToParametrizaciones_SucursalesDTO(this Parametrizaciones_SucursalesDomain parametrizaciones_Sucursales)
        {
            return new Parametrizaciones_SucursalesDTO
            {
                Parametrizacion_Sucursal = parametrizaciones_Sucursales.Parametrizacion_Sucursal,
                ID_Sucursal = parametrizaciones_Sucursales.ID_Sucursal,
                Prefijo_Solicitudes = parametrizaciones_Sucursales.Prefijo_Solicitudes,
                Consecutivo_Solicitudes = parametrizaciones_Sucursales.Consecutivo_Solicitudes,
                Prefijo_Devolucion_S = parametrizaciones_Sucursales.Prefijo_Devolucion_S,
                Consecutivo_Devolucion_S = parametrizaciones_Sucursales.Consecutivo_Devolucion_S,
                Prefijo_Entrega = parametrizaciones_Sucursales.Prefijo_Entrega,
                Consecutivo_Entrega = parametrizaciones_Sucursales.Consecutivo_Entrega,
                Prefijo_Devolucion_E = parametrizaciones_Sucursales.Prefijo_Devolucion_E,
                Consecutivo_Devolucion_E = parametrizaciones_Sucursales.Consecutivo_Devolucion_E,
                Inventario_Inicial = parametrizaciones_Sucursales.Inventario_Inicial,
                Estado = parametrizaciones_Sucursales.Estado
            };
        }      
        public static Parametrizaciones_SucursalesDomain ToParametrizaciones_SucursalesDomain(this Parametrizaciones_SucursalesDomain parametrizaciones_Sucursales)
        {
            return new Parametrizaciones_SucursalesDomain
            {
                Parametrizacion_Sucursal = parametrizaciones_Sucursales.Parametrizacion_Sucursal,
                ID_Sucursal = parametrizaciones_Sucursales.ID_Sucursal,
                Prefijo_Solicitudes = parametrizaciones_Sucursales.Prefijo_Solicitudes,
                Consecutivo_Solicitudes = parametrizaciones_Sucursales.Consecutivo_Solicitudes,
                Prefijo_Devolucion_S = parametrizaciones_Sucursales.Prefijo_Devolucion_S,
                Consecutivo_Devolucion_S = parametrizaciones_Sucursales.Consecutivo_Devolucion_S,
                Prefijo_Entrega = parametrizaciones_Sucursales.Prefijo_Entrega,
                Consecutivo_Entrega = parametrizaciones_Sucursales.Consecutivo_Entrega,
                Prefijo_Devolucion_E = parametrizaciones_Sucursales.Prefijo_Devolucion_E,
                Consecutivo_Devolucion_E = parametrizaciones_Sucursales.Consecutivo_Devolucion_E,
                Inventario_Inicial = parametrizaciones_Sucursales.Inventario_Inicial,
                Estado = parametrizaciones_Sucursales.Estado
            };
        }
    }
}

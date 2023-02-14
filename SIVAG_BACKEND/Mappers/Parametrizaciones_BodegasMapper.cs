using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class Parametrizaciones_BodegasMapper
    {
        public static Parametrizaciones_BodegasDTO ToParametrizacionesBodegasDTO(this Parametrizaciones_BodegasDomain parametrizacionesBodegas)
        {
            return new Parametrizaciones_BodegasDTO
            {
                Parametrizacion_Bodega = parametrizacionesBodegas.Parametrizacion_Bodega,
                ID_Bodega = parametrizacionesBodegas.ID_Bodega,
                INV_Inicial = parametrizacionesBodegas.INV_Inicial,
                Prefijo_Pedido = parametrizacionesBodegas.Prefijo_Pedido,
                Consecutivo_Pedido = parametrizacionesBodegas.Consecutivo_Pedido,
                Trazlado_Prefijo = parametrizacionesBodegas.Trazlado_Prefijo,
                Trazlado_Consecutivo = parametrizacionesBodegas.Trazlado_Consecutivo,
                Estado = parametrizacionesBodegas.Estado
            };
        }        
        public static Parametrizaciones_BodegasDomain ToParametrizacionesBodegasDomain(this Parametrizaciones_BodegasDTO parametrizacionesBodegas)
        {
            return new Parametrizaciones_BodegasDomain
            {
                Parametrizacion_Bodega = parametrizacionesBodegas.Parametrizacion_Bodega,
                ID_Bodega = parametrizacionesBodegas.ID_Bodega,
                INV_Inicial = parametrizacionesBodegas.INV_Inicial,
                Prefijo_Pedido = parametrizacionesBodegas.Prefijo_Pedido,
                Consecutivo_Pedido = parametrizacionesBodegas.Consecutivo_Pedido,
                Trazlado_Prefijo = parametrizacionesBodegas.Trazlado_Prefijo,
                Trazlado_Consecutivo = parametrizacionesBodegas.Trazlado_Consecutivo,
                Estado = parametrizacionesBodegas.Estado
            };
        }
    }
}

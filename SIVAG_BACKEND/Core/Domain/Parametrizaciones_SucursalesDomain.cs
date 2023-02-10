namespace SIVAG_BACKEND.Core.Domain
{
    public class Parametrizaciones_SucursalesDomain
    {
        public int Parametrizacion_Sucursal { get; set; }
        public int ID_Sucursal { get; set; }
        public string? Prefijo_Solicitudes { get; set; }
        public int Consecutivo_Solicitudes { get; set; }
        public string? Prefijo_Devolucion_S { get; set; }
        public int Consecutivo_Devolucion_S { get; set; }
        public string? Prefijo_Entrega { get; set; }
        public int Consecutivo_Entrega { get; set; }
        public string? Prefijo_Devolucion_E { get; set; }
        public int Consecutivo_Devolucion_E { get; set; }
        public bool Inventario_Inicial { get; set; }
        public bool Estado { get; set; }
    }
}

namespace SIVAG_BACKEND.Models.API_Response
{
    public class Parametrizaciones_BodegasDTO
    {
        public int Parametrizacion_Bodega { get; set; }
        public int ID_Bodega { get; set; }
        public bool INV_Inicial { get; set; }
        public string? Prefijo_Pedido { get; set; }
        public int Consecutivo_Pedido { get; set; }
        public string? Trazlado_Prefijo { get; set; }
        public int Trazlado_Consecutivo { get; set; }
        public bool Estado { get; set; }
    }
}

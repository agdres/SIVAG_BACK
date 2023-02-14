namespace SIVAG_BACKEND.Models.API_Response
{
    public class Configuraciones_EmpresasDTO
    {
        public int Configuracion_Empresa { get; set; }
        public int ID_Empresa { get; set; }
        public string? Fecha_Inicio { get; set; }
        public string? Fecha_Fin { get; set; }
        public int Numero_bodegas { get; set; }
        public int Numero_Sucursales { get; set; }
        public bool Facturacion { get; set; }
        public bool Control_Inventario { get; set; }
        public bool WebServices { get; set; }
        public bool Autorretenedor { get; set; }
        public string? Licenciamiento { get; set; }
        public bool Activacion { get; set; }
    }
}

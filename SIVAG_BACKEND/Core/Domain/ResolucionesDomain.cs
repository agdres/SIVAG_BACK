namespace SIVAG_BACKEND.Core.Domain
{
    public class ResolucionesDomain
    {
        public virtual SucursalesDomain IdSucursalNavigation { get; set; }

        public int Resolucion { get; set; }
        public int ID_Sucursal { get; set; }
        public string? Autorizacion { get; set; }
        public string? Fecha_Registro { get; set; }
        public string? Fecha_Expiracion { get; set; }
        public string? Clave { get; set; }
        public string? Prefijo { get; set; }
        public string? Ran_Minimo { get; set; }
        public string? Ran_Maximo { get; set; }
        public int Consecutivo { get; set; }
        public string? Fecha_Creacion { get; set; }
        public string? Fecha_Inactivacion { get; set; }
        public bool Estado { get; set; }
    }
}

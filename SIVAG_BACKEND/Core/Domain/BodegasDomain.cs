namespace SIVAG_BACKEND.Core.Domain
{
    public class BodegasDomain
    {
        public int Bodega { get; set; }
        public int ID_Empresa { get; set; }
        public int ID_Municipio { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Movil { get; set; }
        public string? Correo { get; set; }
        public string? Fecha_Registro { get; set; }
        public bool Estado { get; set; }
    }
}

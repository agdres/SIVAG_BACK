namespace SIVAG_BACKEND.Models.API_Response
{
    public class SucursalesDTO
    {
        public int Sucursal { get; set; }
        public int ID_Empresa { get; set; }
        public int ID_Municipio { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Movil { get; set; }
        public string? Correo { get; set; }
        public int ID_TarifaImpuesto_ICA { get; set; }
        public byte[]? Foto { get; set; }
        public string? Fecha_Registro { get; set; }
        public bool Estado { get; set; }
    }
}

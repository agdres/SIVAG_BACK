namespace SIVAG_BACKEND.Models.API_Response
{
    public class Configuraciones_CorreosDTO
    {
        public int Configuracion_Correo { get; set; }
        public int ID_Sucursal { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Clave { get; set; }
        public string? Servidor { get; set; }
        public int Puesto { get; set; }
        public bool Cifrado_SSL { get; set; }
    }
}

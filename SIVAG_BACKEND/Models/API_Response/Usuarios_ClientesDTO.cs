namespace SIVAG_BACKEND.Models.API_Response
{
    public class Usuarios_ClientesDTO
    {
        public int Usuario_Cliente { get; set; }
        public int ID_Sucursal { get; set; }
        public int ID_Persona { get; set; }
        public int ID_Rol { get; set; }
        public string? Nombre_Usuario { get; set; }
        public string? Clave { get; set; }
        public string? Clave_Temporal { get; set; }
        public TimeSpan Tiempo_Recupera { get; set; }
        public string? Fecha_Creacion { get; set; }
        public bool Estado { get; set; }
    }
}

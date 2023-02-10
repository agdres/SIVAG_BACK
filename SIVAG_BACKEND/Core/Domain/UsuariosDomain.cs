namespace SIVAG_BACKEND.Core.Domain
{
    public class UsuariosDomain
    {
        public int Usuario { get; set; }
        public int ID_Empleado { get; set; }
        public int ID_Rol { get; set; }
        public string? Nombre_Usuario { get; set; }
        public string? Clave { get; set; }
        public string? Clave_Temporal { get; set; }
        public TimeSpan Tiempo_Recupera { get; set; }
        public string? Fecha_Creacion { get; set; }
        public bool Principal { get; set; }
        public bool Estado { get; set; }
    }
}

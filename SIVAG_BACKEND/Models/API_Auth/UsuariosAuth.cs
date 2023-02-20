namespace SIVAG_BACKEND.Models.API_Auth
{
    public class UsuariosAuth
    {
        public int Usuario { get; set; }
        public int ID_Empleado { get; set; }
        public int ID_Rol { get; set; }
        public string? Nombre_Usuario { get; set; }
        public string? Clave { get; set; }
        public bool Principal { get; set; }
        public bool Estado { get; set; }
    }
}

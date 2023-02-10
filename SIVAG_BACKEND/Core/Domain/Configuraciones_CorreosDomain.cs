namespace SIVAG_BACKEND.Core.Domain
{
    public class Configuraciones_CorreosDomain
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

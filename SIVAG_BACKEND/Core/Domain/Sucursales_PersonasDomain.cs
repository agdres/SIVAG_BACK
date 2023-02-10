namespace SIVAG_BACKEND.Core.Domain
{
    public class Sucursales_PersonasDomain
    {
        public int Sucursal_Persona { get; set; }
        public int ID_Sucursal { get; set; }
        public int ID_Persona { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Movil { get; set; }
        public int Tipo_Persona { get; set; }
        public string? Fecha_Registro { get; set; }
        public bool Estado { get; set; }
        public bool Cliente { get; set; }
        public bool Proveedor { get; set; }
    }
}

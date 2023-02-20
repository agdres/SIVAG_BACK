namespace SIVAG_BACKEND.Core.Domain
{
    public class EmpleadosDomain
    {
        public virtual BodegasDomain IdBodegaNavigation { get; set; }
        public virtual GenerosDomain IdGeneroNavigation { get; set; }
        public virtual MunicipiosDomain IdMunicipioExpedicionNavigation { get; set; }
        public virtual MunicipiosDomain IdMunicipioNacimientoNavigation { get; set; }
        public virtual SucursalesDomain IdSucursalNavigation { get; set; }
        public virtual Tipos_DocumentosDomain IdTipoDocumentoNavigation { get; set; }
        public virtual ICollection<UsuariosDomain> Usuarios { get; set; }

        public EmpleadosDomain()
        {
            Usuarios = new HashSet<UsuariosDomain>();
        }

        public int Empleado { get; set; }
        public int? ID_Sucursal { get; set; }
        public int ID_Municipio_Nacimiento { get; set; }
        public string? Fecha_Nacimiento { get; set; }
        public int? ID_Bodega { get; set; }
        public int ID_Genero { get; set; }
        public int ID_Tipo_Documento { get; set; }
        public string? Numero_Documento { get; set; }
        public string? DV { get; set; }
        public int ID_Municipio_Expedicion { get; set; }
        public string? Fecha_Expedicion { get; set; }
        public string? Primer_Nombre { get; set; }
        public string? Segundo_Nombre { get; set; }
        public string? Primer_Apellido { get; set; }
        public string? Segundo_Apellido { get; set; }
        public string? Correo { get; set; }
        public string? Correo_Empresarial { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Movil { get; set; }
        public int Tipo_Persona { get; set; }
        public string? Fecha_Registro { get; set; }
        public bool Estado { get; set; }
    }
}

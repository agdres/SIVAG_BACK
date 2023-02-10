namespace SIVAG_BACKEND.Core.Domain
{
    public class PersonasDomain
    {
        public virtual MunicipiosDomain IdMunicipioNavigation { get; set; }
        public virtual Regimen_FiscalesDomain IdRegimenFiscalNavigation { get; set; }
        public virtual Tipos_DocumentosDomain IdTipoDocumentoNavigation { get; set; }
        public virtual ICollection<EmpresasDomain> Empresas { get; set; }
        public virtual ICollection<Personas_ResponsabilidadesDomain> PersonasResponsabilidades { get; set; }
        public virtual ICollection<Sucursales_PersonasDomain> SucursalesPersonas { get; set; }
        public virtual ICollection<Usuarios_ClientesDomain> UsuariosClientes { get; set; }

        public Persona()
        {
            Empresas = new HashSet<EmpresasDomain>();
            PersonasResponsabilidades = new HashSet<Personas_ResponsabilidadesDomain>();
            SucursalesPersonas = new HashSet<Sucursales_PersonasDomain>();
            UsuariosClientes = new HashSet<Usuarios_ClientesDomain>();
        }

        public int Persona { get; set; }
        public int ID_Tipo_Documento { get; set; }
        public int ID_Municipio { get; set; }
        public int ID_Regimen_Fiscal { get; set; }
        public string? Numero_Documento { get; set; }
        public string? DV { get; set; }
        public string? Nombre_Empresa { get; set; }
        public string? Nombre_Comercial { get; set; }
        public string? Primer_Nombre { get; set; }
        public string? Segundo_Nombre { get; set; }
        public string? Primer_Apellido { get; set; }
        public string? Segundo_Apellido { get; set; }
        public string? Fecha_Registro { get; set; }
        public bool Cliente { get; set; }
        public bool Estado { get; set; }
    }
}

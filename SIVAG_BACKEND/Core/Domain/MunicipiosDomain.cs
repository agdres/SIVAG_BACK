namespace SIVAG_BACKEND.Core.Domain
{
    public class MunicipiosDomain
    {
        public virtual DepartamentosDomain IdDepartamentoNavigation { get; set; }
        public virtual ICollection<BodegasDomain> Bodegas { get; set; }
        public virtual ICollection<EmpleadosDomain> EmpleadoIdMunicipioExpedicionNavigations { get; set; }
        public virtual ICollection<EmpleadosDomain> EmpleadoIdMunicipioNacimientoNavigations { get; set; }
        public virtual ICollection<PersonasDomain> Personas { get; set; }
        public virtual ICollection<SucursalesDomain> Sucursales { get; set; }

        public MunicipiosDomain()
        {
            Bodegas = new HashSet<BodegasDomain>();
            EmpleadoIdMunicipioExpedicionNavigations = new HashSet<EmpleadosDomain>();
            EmpleadoIdMunicipioNacimientoNavigations = new HashSet<EmpleadosDomain>();
            Personas = new HashSet<PersonasDomain>();
            Sucursales = new HashSet<SucursalesDomain>();
        }

        public int Municipio { get; set; }
        public int ID_Departamento { get; set; }
        public string? Descripcion { get; set; }
        public string? Zonapostal { get; set; }
        public bool Estado { get; set; }
    }
}

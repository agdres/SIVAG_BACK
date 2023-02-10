using System.Data;

namespace SIVAG_BACKEND.Core.Domain
{
    public class EmpresasDomain
    {
        public virtual PersonasDomain IdPersonaNavigation { get; set; }
        public virtual ICollection<BodegasDomain> Bodegas { get; set; }
        public virtual ICollection<Configuraciones_DIANDomain> ConfiguracionesDians { get; set; }
        public virtual ICollection<Configuraciones_EmpresasDomain> ConfiguracionesEmpresas { get; set; }
        public virtual ICollection<ImpuestosDomain> Impuestos { get; set; }
        public virtual ICollection<RolesDomain> Roles { get; set; }
        public virtual ICollection<SucursalesDomain> Sucursales { get; set; }

        public EmpresasDomain()
        {
            Bodegas = new HashSet<BodegasDomain>();
            ConfiguracionesDians = new HashSet<Configuraciones_DIANDomain>();
            ConfiguracionesEmpresas = new HashSet<Configuraciones_EmpresasDomain>();
            Impuestos = new HashSet<ImpuestosDomain>();
            Roles = new HashSet<RolesDomain>();
            Sucursales = new HashSet<SucursalesDomain>();
        }

        public int Empresa { get; set; }
        public int ID_Persona { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Movil { get; set; }
        public int Tipo_Persona { get; set; }
        public string? Fecha_Registro { get; set; }
        public bool Estado { get; set; }
    }
}

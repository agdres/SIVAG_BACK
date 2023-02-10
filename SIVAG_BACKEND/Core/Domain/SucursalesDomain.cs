using System.Data;

namespace SIVAG_BACKEND.Core.Domain
{
    public class SucursalesDomain
    {
        public virtual EmpresasDomain IdEmpresaNavigation { get; set; }
        public virtual MunicipiosDomain IdMunicipioNavigation { get; set; }
        public virtual Tarifas_ImpuestosDomain IdTarifaImpuestoIcaNavigation { get; set; }
        public virtual ICollection<Configuraciones_CorreosDomain> ConfiguracionesCorreos { get; set; }
        public virtual ICollection<EmpleadosDomain> Empleados { get; set; }
        public virtual ICollection<Parametrizaciones_SucursalesDomain> ParametrizacionesSucursales { get; set; }
        public virtual ICollection<ResolucionesDomain> Resoluciones { get; set; }
        public virtual ICollection<RolesDomain> Roles { get; set; }
        public virtual ICollection<Sucursales_PersonasDomain> SucursalesPersonas { get; set; }
        public virtual ICollection<Usuarios_ClientesDomain> UsuariosClientes { get; set; }

        public SucursalesDomain()
        {
            ConfiguracionesCorreos = new HashSet<Configuraciones_CorreosDomain>();
            Empleados = new HashSet<EmpleadosDomain>();
            ParametrizacionesSucursales = new HashSet<Parametrizaciones_SucursalesDomain>();
            Resoluciones = new HashSet<ResolucionesDomain>();
            Roles = new HashSet<RolesDomain>();
            SucursalesPersonas = new HashSet<Sucursales_PersonasDomain>();
            UsuariosClientes = new HashSet<Usuarios_ClientesDomain>();
        }

        public int Sucursal { get; set; }
        public int ID_Empresa { get; set; }
        public int ID_Municipio { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Movil { get; set; }
        public string? Correo { get; set; }
        public int ID_TarifaImpuesto_ICA { get; set; }
        public byte[]? Foto { get; set; }
        public string? Fecha_Registro { get; set; }
        public bool Estado { get; set; }
    }
}

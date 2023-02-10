using System.Data;

namespace SIVAG_BACKEND.Core.Domain
{
    public class BodegasDomain
    {
        public virtual EmpresasDomain IdEmpresaNavigation { get; set; }
        public virtual MunicipiosDomain IdMunicipioNavigation { get; set; }
        public virtual ICollection<EmpleadosDomain> Empleados { get; set; }
        public virtual ICollection<Parametrizaciones_BodegasDomain> ParametrizacionesBodegas { get; set; }
        public virtual ICollection<RolesDomain> Roles { get; set; }

        public BodegasDomain()
        {
            Empleados = new HashSet<EmpleadosDomain>();
            ParametrizacionesBodegas = new HashSet<Parametrizaciones_BodegasDomain>();
            Roles = new HashSet<RolesDomain>();
        }

        public int Bodega { get; set; }
        public int ID_Empresa { get; set; }
        public int ID_Municipio { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Movil { get; set; }
        public string? Correo { get; set; }
        public string? Fecha_Registro { get; set; }
        public bool Estado { get; set; }
    }
}

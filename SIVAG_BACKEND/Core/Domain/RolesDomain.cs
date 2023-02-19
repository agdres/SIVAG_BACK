namespace SIVAG_BACKEND.Core.Domain
{
    public class RolesDomain
    {
        public virtual BodegasDomain IdBodegaNavigation { get; set; }
        public virtual EmpresasDomain IdEmpresaNavigation { get; set; }
        public virtual SucursalesDomain IdSucursalNavigation { get; set; }
        public virtual ICollection<PermisosDomain> Permisos { get; set; }
        public virtual ICollection<UsuariosDomain> Usuarios { get; set; }
        public virtual ICollection<Usuarios_ClientesDomain> UsuariosClientes { get; set; }

        public RolesDomain()
        {
            Permisos = new HashSet<PermisosDomain>();
            Usuarios = new HashSet<UsuariosDomain>();
            UsuariosClientes = new HashSet<Usuarios_ClientesDomain>();
        }

        public int Rol { get; set; }
        public int ID_Empresa { get; set; }
        public int ID_Sucursal { get; set; }
        public int ID_Bodega { get; set; }
        public string? Descripcion { get; set; }
        public bool Compartido { get; set; }
        public bool Estado { get; set; }
    }
}

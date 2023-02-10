using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;

namespace SIVAG_BACKEND.Core.Domain
{
    public class Usuarios_ClientesDomain
    {
        public virtual PersonasDomain IdPersonaNavigation { get; set; }
        public virtual RolesDomain IdRolNavigation { get; set; }
        public virtual SucursalesDomain IdSucursalNavigation { get; set; }
        public virtual ICollection<ErroresDomain> Errores { get; set; }
        public virtual ICollection<RegistrosDomain> Registros { get; set; }

        public Usuarios_ClientesDomain()
        {
            Errores = new HashSet<ErroresDomain>();
            Registros = new HashSet<RegistrosDomain>();
        }

        public int Usuario_Cliente { get; set; }
        public int ID_Sucursal { get; set; }
        public int ID_Persona { get; set; }
        public int ID_Rol { get; set; }
        public string? Nombre_Usuario { get; set; }
        public string? Clave { get; set; }
        public string? Clave_Temporal { get; set; }
        public TimeSpan Tiempo_Recupera { get; set; }
        public string? Fecha_Creacion { get; set; }
        public bool Estado { get; set; }
    }
}

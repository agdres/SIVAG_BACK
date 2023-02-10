using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SIVAG_BACKEND.Core.Domain
{
    public class ComponentesDomain
    {
        public virtual ICollection<ErroresDomain> Errores { get; set; }
        public virtual ICollection<PermisosDomain> Permisos { get; set; }
        public virtual ICollection<RegistrosDomain> Registros { get; set; }

        public ComponentesDomain()
        {
            Errores = new HashSet<ErroresDomain>();
            Permisos = new HashSet<PermisosDomain>();
            Registros = new HashSet<RegistrosDomain>();
        }

        public int Componente { get; set; }
        public string? Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}

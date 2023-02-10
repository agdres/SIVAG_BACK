using System.Data;

namespace SIVAG_BACKEND.Core.Domain
{
    public class PermisosDomain
    {
        public virtual ComponentesDomain IdComponenteNavigation { get; set; }
        public virtual RolesDomain IdRolNavigation { get; set; }

        public int Permiso { get; set; }
        public int ID_Rol { get; set; }
        public int ID_Componente { get; set; }
        public bool Crear { get; set; }
        public bool Listar { get; set; }
        public bool Actualizar { get; set; }
        public bool Deshabilitar { get; set; }
        public bool Enviar_MsgBod { get; set; }
        public bool Recibir_MsgBod { get; set; }
        public bool S_Enviar_MsgBod { get; set; }
        public bool S_Recibir_MsgBod { get; set; }
        public bool Estado { get; set; }
    }
}

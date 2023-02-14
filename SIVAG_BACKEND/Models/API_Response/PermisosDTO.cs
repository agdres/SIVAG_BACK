namespace SIVAG_BACKEND.Models.API_Response
{
    public class PermisosDTO
    {
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

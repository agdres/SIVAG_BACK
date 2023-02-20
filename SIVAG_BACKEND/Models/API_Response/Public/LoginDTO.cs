namespace SIVAG_BACKEND.Models.API_Response.Public
{
    public class LoginDTO
    {
        public List<string> isUserx_res { get; set; }
        public List<LoginPermisos> isUsery_m { get; set; }
    }
    public class LoginPermisos
    {
        public int Componente { get; set; }
        public bool Crear { get; set; }
        public bool Listar { get; set; }
        public bool Actualizar { get; set; }
        public bool Deshabilitar { get; set; }
        public bool Enviar_MsgBod { get; set; }
        public bool Recibir_MsgBod { get; set; }
        public bool S_Enviar_MsgBod { get; set; }
        public bool S_Recibir_MsgBod { get; set; }
    }

    public class LoginRes
    {
        public string? ms { get; set; }
        public string? token { get; set; }
    }
}

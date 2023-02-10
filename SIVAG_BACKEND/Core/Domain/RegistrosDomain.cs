namespace SIVAG_BACKEND.Core.Domain
{
    public class RegistrosDomain
    {
        public virtual ComponentesDomain IdComponenteNavigation { get; set; }
        public virtual EventosDomain IdEventoNavigation { get; set; }
        public virtual Usuarios_ClientesDomain IdUsuarioClienteNavigation { get; set; }
        public virtual UsuariosDomain IdUsuarioNavigation { get; set; }

        public int Registro { get; set; }
        public int ID_Evento { get; set; }
        public int ID_Usuario { get; set; }
        public int ID_Usuario_Cliente { get; set; }
        public int ID_Componente { get; set; }
        public string? Descripcion { get; set; }
        public string? IP { get; set; }
        public string? Fecha_Registro { get; set; }
    }
}

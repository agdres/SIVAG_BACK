namespace SIVAG_BACKEND.Core.Domain
{
    public class RegistrosDomain
    {
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

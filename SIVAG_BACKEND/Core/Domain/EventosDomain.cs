namespace SIVAG_BACKEND.Core.Domain
{
    public class EventosDomain
    {
        public int Evento { get; set; }
        public string? Descripcion { get; set; }
        public bool Sucursal { get; set; }
        public bool Bodega { get; set; }
        public bool Estado { get; set; }
    }
}

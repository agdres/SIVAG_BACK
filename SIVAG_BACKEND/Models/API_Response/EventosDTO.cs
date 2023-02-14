namespace SIVAG_BACKEND.Models.API_Response
{
    public class EventosDTO
    {
        public int Evento { get; set; }
        public string? Descripcion { get; set; }
        public bool Sucursal { get; set; }
        public bool Bodega { get; set; }
        public bool Estado { get; set; }
    }
}

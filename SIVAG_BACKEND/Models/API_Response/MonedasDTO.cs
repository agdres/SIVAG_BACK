namespace SIVAG_BACKEND.Models.API_Response
{
    public class MonedasDTO
    {
        public int Moneda { get; set; }
        public string? Descripcion { get; set; }
        public string? Simbolo { get; set; }
        public string? Codigo { get; set; }
        public bool Estado { get; set; }
    }
}

namespace SIVAG_BACKEND.Models.API_Response
{
    public class PaisesDTO
    {
        public int Pais { get; set; }
        public string? Descripcion { get; set; }
        public string? Alfa_2 { get; set; }
        public string? Alfa_3 { get; set; }
        public string? Codigo { get; set; }
        public bool Estado { get; set; }
    }
}

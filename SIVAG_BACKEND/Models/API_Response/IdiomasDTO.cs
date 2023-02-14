namespace SIVAG_BACKEND.Models.API_Response
{
    public class IdiomasDTO
    {
        public int Idioma { get; set; }
        public string? Descripcion { get; set; }
        public string? ISO_639_1 { get; set; }
        public string? ISO_639_2 { get; set; }
        public bool Estado { get; set; }
    }
}

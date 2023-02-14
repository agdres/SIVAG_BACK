namespace SIVAG_BACKEND.Models.API_Response
{
    public class Tipos_DocumentosDTO
    {
        public int Tipo_Documento { get; set; }
        public string? Descripcion { get; set; }
        public string? Abreviatura { get; set; }
        public bool Estado { get; set; }
    }
}

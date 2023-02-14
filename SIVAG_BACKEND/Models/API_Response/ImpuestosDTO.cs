namespace SIVAG_BACKEND.Models.API_Response
{
    public class ImpuestosDTO
    {
        public int Impuesto { get; set; }
        public int ID_Empresa { get; set; }
        public string? Descripcion { get; set; }
        public string? Fecha_Implementacion { get; set; }
        public bool Estado { get; set; }
    }
}

namespace SIVAG_BACKEND.Models.API_Response
{
    public class DepartamentosDTO
    {
        public int Departamento { get; set; }
        public int ID_Pais { get; set; }
        public string? Descripcion { get; set; }
        public string? Codigo_ISO { get; set; }
        public string? Codigo { get; set; }
        public bool Estado { get; set; }
    }
}

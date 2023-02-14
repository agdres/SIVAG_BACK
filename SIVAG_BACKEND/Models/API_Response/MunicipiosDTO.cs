namespace SIVAG_BACKEND.Models.API_Response
{
    public class MunicipiosDTO
    {
        public int Municipio { get; set; }
        public int ID_Departamento { get; set; }
        public string? Descripcion { get; set; }
        public string? Zonapostal { get; set; }
        public string? Codigo { get; set; }
        public bool Estado { get; set; }
    }
}

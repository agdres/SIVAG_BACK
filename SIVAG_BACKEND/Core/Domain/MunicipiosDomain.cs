namespace SIVAG_BACKEND.Core.Domain
{
    public class MunicipiosDomain
    {
        public int Municipio { get; set; }
        public int ID_Departamento { get; set; }
        public string? Descripcion { get; set; }
        public string? Zonapostal { get; set; }
        public bool Estado { get; set; }
    }
}

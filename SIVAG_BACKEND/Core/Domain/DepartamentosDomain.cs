namespace SIVAG_BACKEND.Core.Domain
{
    public class DepartamentosDomain
    {
        public int Departamento { get; set; }
        public int ID_Pais { get; set; }
        public string? Descripcion { get; set; }
        public string? Codigo_ISO { get; set; }
        public bool Estado { get; set; }
    }
}

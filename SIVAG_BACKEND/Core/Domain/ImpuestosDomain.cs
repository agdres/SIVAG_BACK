namespace SIVAG_BACKEND.Core.Domain
{
    public class ImpuestosDomain
    {
        public int Impuesto { get; set; }
        public int ID_Empresa { get; set; }
        public string? Descripcion { get; set; }
        public string? Fecha_Implementacion { get; set; }
        public bool Estado { get; set; }
    }
}

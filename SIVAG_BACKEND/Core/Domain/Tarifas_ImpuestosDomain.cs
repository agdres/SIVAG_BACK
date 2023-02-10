namespace SIVAG_BACKEND.Core.Domain
{
    public class Tarifas_ImpuestosDomain
    {
        public int Tarifa_Impuesto { get; set; }
        public int ID_Impuesto { get; set; }
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public decimal Valor { get; set; }
        public decimal Maximo { get; set; }
        public decimal Minimo { get; set; }
        public bool Estado { get; set; }
    }
}

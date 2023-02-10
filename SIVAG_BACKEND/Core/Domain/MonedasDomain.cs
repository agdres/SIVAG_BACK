namespace SIVAG_BACKEND.Core.Domain
{
    public class MonedasDomain
    {
        public virtual PaisesDomain IdPaisNavigation { get; set; }


        public int Moneda { get; set; }
        public int ID_Pais { get; set; }
        public PaisesDomain? Pais { get; set; }
        public string? Descripcion { get; set; }
        public string? Simbolo { get; set; }
        public bool Estado { get; set; }
    }
}

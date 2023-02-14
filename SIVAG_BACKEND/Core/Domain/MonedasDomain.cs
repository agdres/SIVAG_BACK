namespace SIVAG_BACKEND.Core.Domain
{
    public class MonedasDomain
    {
        //public virtual PaisesDomain IdPaisNavigation { get; set; }
        public virtual ICollection<Monedas_PaisesDomain> MonedaPais { get; set; }

        public MonedasDomain() 
        {
            MonedaPais = new HashSet<Monedas_PaisesDomain>();
        }

        //public int ID_Pais { get; set; }
        public int Moneda { get; set; }
        public string? Descripcion { get; set; }
        public string? Simbolo { get; set; }
        public string? Codigo { get; set; }
        public bool Estado { get; set; }
    }
}

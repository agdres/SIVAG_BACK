namespace SIVAG_BACKEND.Core.Domain
{
    public class Monedas_PaisesDomain
    {
        public virtual PaisesDomain? IdPaisNavigation { get; set; }
        public virtual MonedasDomain? IdMonedaNavigation { get; set; }

        public int Moneda_Pais { get; set; }
        public int ID_Moneda { get; set; }
        public int ID_Pais { get; set; }
        public bool Estado { get; set; }
    }
}

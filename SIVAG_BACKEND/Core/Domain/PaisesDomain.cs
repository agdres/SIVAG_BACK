namespace SIVAG_BACKEND.Core.Domain
{
    public class PaisesDomain
    {
        public virtual ICollection<DepartamentosDomain> Departamentos { get; set; }
        public virtual ICollection<Paises_IdiomasDomain> Idiomas_Paises { get; set; }
        public virtual ICollection<MonedasDomain> Moneda { get; set; }

        public PaisesDomain()
        {
            Departamentos = new HashSet<DepartamentosDomain>();
            Idiomas_Paises = new HashSet<Paises_IdiomasDomain>();
            Moneda = new HashSet<MonedasDomain>();
        }

        public int Pais { get; set; }
        public string? Descripcion { get; set; }
        public string? Alfa_2 { get; set; }
        public string? Alfa_3 { get; set; }
        public string? Codigo { get; set; }
        public bool Estado { get; set; }
    }
}

namespace SIVAG_BACKEND.Core.Domain
{
    public class PaisesDomain
    {
        public virtual ICollection<DepartamentosDomain> Departamentos { get; set; }
        public virtual ICollection<IdiomasDomain> Idiomas { get; set; }
        public virtual ICollection<MonedasDomain> Moneda { get; set; }

        public PaisesDomain()
        {
            Departamentos = new HashSet<DepartamentosDomain>();
            Idiomas = new HashSet<IdiomasDomain>();
            Moneda = new HashSet<MonedasDomain>();
        }

        public int Pais { get; set; }
        public string? Descripcion { get; set; }
        public string? Alfa_2 { get; set; }
        public string? Alfa_3 { get; set; }
        public bool Estado { get; set; }
    }
}

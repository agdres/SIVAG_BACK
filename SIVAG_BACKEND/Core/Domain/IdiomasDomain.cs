namespace SIVAG_BACKEND.Core.Domain
{
    public class IdiomasDomain
    {

        public virtual ICollection<Paises_IdiomasDomain> Idiomas_Paises { get; set; }

        public IdiomasDomain()
        {
            Idiomas_Paises = new HashSet<Paises_IdiomasDomain>();
        }


        public int Idioma { get; set; }
        public string? Descripcion { get; set; }
        public string? ISO_639_1 { get; set; }
        public string? ISO_639_2 { get; set; }
        public bool Estado { get; set; }
    }
}

namespace SIVAG_BACKEND.Core.Domain
{
    public class Paises_IdiomasDomain
    {
        public virtual PaisesDomain IdPaisNavigation { get; set; }
        public virtual IdiomasDomain IdIdiomaNavigation { get; set; }

        public int Pais_Idioma { get; set; }
        public int ID_Pais { get; set; }
        public int ID_Idioma { get; set; }
        public bool Estado { get; set; }

    }
}

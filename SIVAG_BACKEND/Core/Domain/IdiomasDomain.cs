namespace SIVAG_BACKEND.Core.Domain
{
    public class IdiomasDomain
    {
        public virtual PaisesDomain IdPaisNavigation { get; set; }


        public int Idioma { get; set; }
        public int ID_Pais { get; set; }
        public string? Descripcion { get; set; }
        public string? ISO_639_1 { get; set; }
        public string? ISO_639_2 { get; set; }
        public bool Estado { get; set; }
    }
}

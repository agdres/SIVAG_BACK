namespace SIVAG_BACKEND.Core.Domain
{
    public class Regimen_FiscalesDomain
    {
        public virtual ICollection<PersonasDomain> Personas { get; set; }


        public int RegimenFiscal { get; set; }
        public string? Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}

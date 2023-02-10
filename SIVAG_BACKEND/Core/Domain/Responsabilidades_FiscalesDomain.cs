namespace SIVAG_BACKEND.Core.Domain
{
    public class Responsabilidades_FiscalesDomain
    {
        public virtual ICollection<Personas_ResponsabilidadesDomain> PersonasResponsabilidades { get; set; }
        public Responsabilidades_FiscalesDomain()
        {
            PersonasResponsabilidades = new HashSet<Personas_ResponsabilidadesDomain>();
        }


        public int Responsabilidad_Fiscal { get; set; }
        public string? Descripcion { get; set; }
        public string? Codigo { get; set; }
        public bool Estado { get; set; }
    }
}

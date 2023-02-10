namespace SIVAG_BACKEND.Core.Domain
{
    public class Personas_ResponsabilidadesDomain
    {
        public virtual PersonasDomain IdPersonaNavigation { get; set; }
        public virtual Responsabilidades_FiscalesDomain IdResponsabilidadFiscalNavigation { get; set; }

        public int Persona_Responsabilidad { get; set; }
        public int ID_Persona { get; set; }
        public int ID_Responsabilidad_Fiscal { get; set; }
        public bool Estado { get; set; }
    }
}

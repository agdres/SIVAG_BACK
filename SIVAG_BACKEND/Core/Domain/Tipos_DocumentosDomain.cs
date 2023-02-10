namespace SIVAG_BACKEND.Core.Domain
{
    public class Tipos_DocumentosDomain
    {
        public virtual ICollection<EmpleadosDomain> Empleados { get; set; }
        public virtual ICollection<PersonasDomain> Personas { get; set; }

        public Tipos_DocumentosDomain()
        {
            Empleados = new HashSet<EmpleadosDomain>();
            Personas = new HashSet<PersonasDomain>();
        }

        public int Tipo_Documento { get; set; }
        public string? Descripcion { get; set; }
        public string? Abreviatura { get; set; }
        public bool Estado { get; set; }
    }
}

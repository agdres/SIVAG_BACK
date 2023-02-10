namespace SIVAG_BACKEND.Core.Domain
{
    public class PersonasDomain
    {
        public int Persona { get; set; }
        public int ID_Tipo_Documento { get; set; }
        public int ID_Municipio { get; set; }
        public int ID_Regimen_Fiscal { get; set; }
        public string? Numero_Documento { get; set; }
        public string? DV { get; set; }
        public string? Nombre_Empresa { get; set; }
        public string? Nombre_Comercial { get; set; }
        public string? Primer_Nombre { get; set; }
        public string? Segundo_Nombre { get; set; }
        public string? Primer_Apellido { get; set; }
        public string? Segundo_Apellido { get; set; }
        public string? Fecha_Registro { get; set; }
        public bool Cliente { get; set; }
        public bool Estado { get; set; }
    }
}

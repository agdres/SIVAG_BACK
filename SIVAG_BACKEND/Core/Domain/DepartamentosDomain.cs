namespace SIVAG_BACKEND.Core.Domain
{
    public class DepartamentosDomain
    {
        public virtual PaisesDomain IdPaisNavigation { get; set; }
        public virtual ICollection<MunicipiosDomain> Municipios { get; set; }

        public DepartamentosDomain()
        {
            Municipios = new HashSet<MunicipiosDomain>();
        }

        public int Departamento { get; set; }
        public int ID_Pais { get; set; }
        public string? Descripcion { get; set; }
        public string? Codigo_ISO { get; set; }
        public string? Codigo { get; set; }
        public bool Estado { get; set; }
    }
}

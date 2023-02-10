namespace SIVAG_BACKEND.Core.Domain
{
    public class GenerosDomain
    {
        public virtual ICollection<EmpleadosDomain> Empleados { get; set; }

        public GenerosDomain() 
        {
            Empleados = new HashSet<EmpleadosDomain>();

        }

        public int Genero { get; set; }
        public string? Descripcion { get; set; }
        public string? Abreviatura { get; set; }
        public bool Estado { get; set; }
    }
}

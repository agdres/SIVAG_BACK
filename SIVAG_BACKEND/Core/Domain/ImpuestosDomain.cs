namespace SIVAG_BACKEND.Core.Domain
{
    public class ImpuestosDomain
    {
        public virtual EmpresasDomain IdEmpresaNavigation { get; set; }
        public virtual ICollection<Tarifas_ImpuestosDomain> TarifasImpuestos { get; set; }

        public ImpuestosDomain() 
        {
            TarifasImpuestos = new HashSet<Tarifas_ImpuestosDomain>();
        }

        public int Impuesto { get; set; }
        public int ID_Empresa { get; set; }
        public string? Descripcion { get; set; }
        public string? Fecha_Implementacion { get; set; }
        public bool Estado { get; set; }
    }
}

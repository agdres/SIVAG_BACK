using Microsoft.Win32;

namespace SIVAG_BACKEND.Core.Domain
{
    public class EventosDomain
    {
        public virtual ICollection<RegistrosDomain> Registros { get; set; }

        public EventosDomain() 
        {
            Registros = new HashSet<RegistrosDomain>();
        }

        public int Evento { get; set; }
        public string? Descripcion { get; set; }
        public bool Sucursal { get; set; }
        public bool Bodega { get; set; }
        public bool Estado { get; set; }
    }
}

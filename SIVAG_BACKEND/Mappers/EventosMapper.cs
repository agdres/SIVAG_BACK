using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class EventosMapper
    {
        public static EventosDTO ToEventosDTO(this EventosDomain eventos)
        {
            return new EventosDTO
            {
                Evento = eventos.Evento,
                Descripcion = eventos.Descripcion,
                Sucursal = eventos.Sucursal,
                Bodega = eventos.Bodega,
                Estado = eventos.Estado
            };
        }        
        
        public static EventosDomain ToEventosDomain(this EventosDTO eventos)
        {
            return new EventosDomain
            {
                Evento = eventos.Evento,
                Descripcion = eventos.Descripcion,
                Sucursal = eventos.Sucursal,
                Bodega = eventos.Bodega,
                Estado = eventos.Estado
            };
        }
    }
}

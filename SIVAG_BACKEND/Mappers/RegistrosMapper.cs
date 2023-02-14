using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class RegistrosMapper
    {
        public static RegistrosDTO ToRegistrosDTO(this RegistrosDomain registros)
        {
            return new RegistrosDTO
            {
                Registro = registros.Registro,
                ID_Evento = registros.ID_Evento,
                ID_Usuario = registros.ID_Usuario,
                ID_Usuario_Cliente = registros.ID_Usuario_Cliente,
                ID_Componente = registros.ID_Componente,
                Descripcion = registros.Descripcion,
                IP = registros.IP,
                Fecha_Registro = registros.Fecha_Registro
            };
        }
        public static RegistrosDomain ToRegistrosDomain(this RegistrosDTO registros)
        {
            return new RegistrosDomain
            {
                Registro = registros.Registro,
                ID_Evento = registros.ID_Evento,
                ID_Usuario = registros.ID_Usuario,
                ID_Usuario_Cliente = registros.ID_Usuario_Cliente,
                ID_Componente = registros.ID_Componente,
                Descripcion = registros.Descripcion,
                IP = registros.IP,
                Fecha_Registro = registros.Fecha_Registro
            };
        }
    }
}

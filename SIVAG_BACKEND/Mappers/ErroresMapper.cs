using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class ErroresMapper
    {
        public static ErroresDTO ToErroresDTO(this ErroresDomain errores)
        {
            return new ErroresDTO
            {
                Error = errores.Error,
                ID_Usuario = errores.ID_Usuario,
                ID_Usuario_Cliente = errores.ID_Usuario_Cliente,
                ID_Componente = errores.ID_Componente,
                Descripcion = errores.Descripcion,
                IP = errores.IP,
                Fecha_Error = errores.Fecha_Error
            };
        }
        
        public static ErroresDomain ToErroresDomain(this ErroresDTO errores)
        {
            return new ErroresDomain
            {
                Error = errores.Error,
                ID_Usuario = errores.ID_Usuario,
                ID_Usuario_Cliente = errores.ID_Usuario_Cliente,
                ID_Componente = errores.ID_Componente,
                Descripcion = errores.Descripcion,
                IP = errores.IP,
                Fecha_Error = errores.Fecha_Error
            };
        }
    }
}

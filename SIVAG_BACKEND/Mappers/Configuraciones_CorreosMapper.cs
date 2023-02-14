using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class Configuraciones_CorreosMapper
    {
        public static Configuraciones_CorreosDTO ToConfiguraciones_CorreosDTO(this Configuraciones_CorreosDomain configuracionesCorreos)
        {
            return new Configuraciones_CorreosDTO
            {
                Configuracion_Correo = configuracionesCorreos.Configuracion_Correo,
                ID_Sucursal = configuracionesCorreos.ID_Sucursal,
                Nombre = configuracionesCorreos.Nombre,
                Correo = configuracionesCorreos.Correo,
                Clave = configuracionesCorreos.Clave,
                Servidor = configuracionesCorreos.Servidor,
                Puesto = configuracionesCorreos.Puesto,
                Cifrado_SSL = configuracionesCorreos.Cifrado_SSL
            };
        }       
        public static Configuraciones_CorreosDomain ToConfiguraciones_CorreosDomain(this Configuraciones_CorreosDTO configuracionesCorreos)
        {
            return new Configuraciones_CorreosDomain
            {
                Configuracion_Correo = configuracionesCorreos.Configuracion_Correo,
                ID_Sucursal = configuracionesCorreos.ID_Sucursal,
                Nombre = configuracionesCorreos.Nombre,
                Correo = configuracionesCorreos.Correo,
                Clave = configuracionesCorreos.Clave,
                Servidor = configuracionesCorreos.Servidor,
                Puesto = configuracionesCorreos.Puesto,
                Cifrado_SSL = configuracionesCorreos.Cifrado_SSL
            };
        }
    }
}

using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class Configuraciones_DIANMapper
    {
        public static Configuraciones_DIANDTO ToConfiguraciones_DIANDTO(this Configuraciones_DIANDomain configuracion)
        {
            return new Configuraciones_DIANDTO
            {
                Configuracion_DIAN = configuracion.Configuracion_DIAN,
                ID_Empresa = configuracion.ID_Empresa,
                Codigo_Software = configuracion.Codigo_Software,
                Pin_Software = configuracion.Pin_Software,
                Pruebas = configuracion.Pruebas,
                Clave = configuracion.Clave
            };
        }        
        public static Configuraciones_DIANDomain ToConfiguraciones_DIANDomain(this Configuraciones_DIANDTO configuracion)
        {
            return new Configuraciones_DIANDomain
            {
                Configuracion_DIAN = configuracion.Configuracion_DIAN,
                ID_Empresa = configuracion.ID_Empresa,
                Codigo_Software = configuracion.Codigo_Software,
                Pin_Software = configuracion.Pin_Software,
                Pruebas = configuracion.Pruebas,
                Clave = configuracion.Clave
            };
        }
    }
}

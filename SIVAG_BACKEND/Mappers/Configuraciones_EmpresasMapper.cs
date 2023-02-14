using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class Configuraciones_EmpresasMapper
    {
        public static Configuraciones_EmpresasDTO ToConfiguraciones_EmpresasDTO(this Configuraciones_EmpresasDomain configuracionesEmpresas)
        {
            return new Configuraciones_EmpresasDTO
            {
                Configuracion_Empresa = configuracionesEmpresas.Configuracion_Empresa,
                ID_Empresa = configuracionesEmpresas.ID_Empresa,
                Fecha_Inicio = configuracionesEmpresas.Fecha_Inicio,
                Fecha_Fin = configuracionesEmpresas.Fecha_Fin,
                Numero_bodegas = configuracionesEmpresas.Numero_bodegas,
                Numero_Sucursales = configuracionesEmpresas.Numero_Sucursales,
                Facturacion = configuracionesEmpresas.Facturacion,
                Control_Inventario = configuracionesEmpresas.Control_Inventario,
                WebServices = configuracionesEmpresas.WebServices,
                Autorretenedor = configuracionesEmpresas.Autorretenedor,
                Licenciamiento = configuracionesEmpresas.Licenciamiento,
                Activacion = configuracionesEmpresas.Activacion
            };
        }       

        public static Configuraciones_EmpresasDomain ToConfiguraciones_EmpresasDomain(this Configuraciones_EmpresasDTO configuracionesEmpresas)
        {
            return new Configuraciones_EmpresasDomain
            {
                Configuracion_Empresa = configuracionesEmpresas.Configuracion_Empresa,
                ID_Empresa = configuracionesEmpresas.ID_Empresa,
                Fecha_Inicio = configuracionesEmpresas.Fecha_Inicio,
                Fecha_Fin = configuracionesEmpresas.Fecha_Fin,
                Numero_bodegas = configuracionesEmpresas.Numero_bodegas,
                Numero_Sucursales = configuracionesEmpresas.Numero_Sucursales,
                Facturacion = configuracionesEmpresas.Facturacion,
                Control_Inventario = configuracionesEmpresas.Control_Inventario,
                WebServices = configuracionesEmpresas.WebServices,
                Autorretenedor = configuracionesEmpresas.Autorretenedor,
                Licenciamiento = configuracionesEmpresas.Licenciamiento,
                Activacion = configuracionesEmpresas.Activacion
            };
        }
    }
}

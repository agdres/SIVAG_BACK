using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class Sucursales_PersonasMapper
    {
        public static Sucursales_PersonasDTO ToSucursales_PersonasDTO(this Sucursales_PersonasDomain sucursalesPersonas)
        {
            return new Sucursales_PersonasDTO
            {
                Sucursal_Persona = sucursalesPersonas.Sucursal_Persona,
                ID_Sucursal = sucursalesPersonas.ID_Sucursal,
                ID_Persona = sucursalesPersonas.ID_Persona,
                Correo = sucursalesPersonas.Correo,
                Direccion = sucursalesPersonas.Direccion,
                Telefono = sucursalesPersonas.Telefono,
                Movil = sucursalesPersonas.Movil,
                Tipo_Persona = sucursalesPersonas.Tipo_Persona,
                Fecha_Registro = sucursalesPersonas.Fecha_Registro,
                Estado = sucursalesPersonas.Estado,
                Cliente = sucursalesPersonas.Cliente,
                Proveedor = sucursalesPersonas.Proveedor
            };
        }
        public static Sucursales_PersonasDomain ToSucursales_PersonasDomain(this Sucursales_PersonasDTO sucursalesPersonas)
        {
            return new Sucursales_PersonasDomain
            {
                Sucursal_Persona = sucursalesPersonas.Sucursal_Persona,
                ID_Sucursal = sucursalesPersonas.ID_Sucursal,
                ID_Persona = sucursalesPersonas.ID_Persona,
                Correo = sucursalesPersonas.Correo,
                Direccion = sucursalesPersonas.Direccion,
                Telefono = sucursalesPersonas.Telefono,
                Movil = sucursalesPersonas.Movil,
                Tipo_Persona = sucursalesPersonas.Tipo_Persona,
                Fecha_Registro = sucursalesPersonas.Fecha_Registro,
                Estado = sucursalesPersonas.Estado,
                Cliente = sucursalesPersonas.Cliente,
                Proveedor = sucursalesPersonas.Proveedor
            };
        }
    }
}

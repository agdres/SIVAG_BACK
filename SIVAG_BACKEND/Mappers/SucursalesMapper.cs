using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class SucursalesMapper
    {
        public static SucursalesDTO ToSucursalesDTO(this SucursalesDomain sucursal)
        {
            return new SucursalesDTO
            {
                Sucursal = sucursal.Sucursal,
                ID_Empresa = sucursal.ID_Empresa,
                ID_Municipio = sucursal.ID_Municipio,
                Codigo = sucursal.Codigo,
                Nombre = sucursal.Nombre,
                Direccion = sucursal.Direccion,
                Telefono = sucursal.Telefono,
                Movil = sucursal.Movil,
                Correo = sucursal.Correo,
                ID_TarifaImpuesto_ICA = sucursal.ID_TarifaImpuesto_ICA,
                Foto = sucursal.Foto,
                Fecha_Registro = sucursal.Fecha_Registro,
                Estado = sucursal.Estado
            };
        }

        public static SucursalesDomain ToSucursalesDomain(this SucursalesDTO sucursal)
        {
            return new SucursalesDomain
            {
                Sucursal = sucursal.Sucursal,
                ID_Empresa = sucursal.ID_Empresa,
                ID_Municipio = sucursal.ID_Municipio,
                Codigo = sucursal.Codigo,
                Nombre = sucursal.Nombre,
                Direccion = sucursal.Direccion,
                Telefono = sucursal.Telefono,
                Movil = sucursal.Movil,
                Correo = sucursal.Correo,
                ID_TarifaImpuesto_ICA = sucursal.ID_TarifaImpuesto_ICA,
                Foto = sucursal.Foto,
                Fecha_Registro = sucursal.Fecha_Registro,
                Estado = sucursal.Estado
            };
        }
    }
}

using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class BodegasMapper
    {
        public static BodegasDTO ToBodegasDTO(this BodegasDomain bodegas)
        {
            return new BodegasDTO
            {
                Bodega = bodegas.Bodega,
                ID_Empresa = bodegas.ID_Empresa,
                ID_Municipio = bodegas.ID_Municipio,
                Nombre = bodegas.Nombre,
                Direccion = bodegas.Direccion,
                Telefono = bodegas.Telefono,
                Movil = bodegas.Movil,
                Correo = bodegas.Correo,
                Fecha_Registro = bodegas.Fecha_Registro,
                Estado = bodegas.Estado
            };
        } 
        
        public static BodegasDomain ToBodegasDomain(this BodegasDTO bodegas)
        {
            return new BodegasDomain
            {
                Bodega = bodegas.Bodega,
                ID_Empresa = bodegas.ID_Empresa,
                ID_Municipio = bodegas.ID_Municipio,
                Nombre = bodegas.Nombre,
                Direccion = bodegas.Direccion,
                Telefono = bodegas.Telefono,
                Movil = bodegas.Movil,
                Correo = bodegas.Correo,
                Fecha_Registro = bodegas.Fecha_Registro,
                Estado = bodegas.Estado
            };
        }
    }
}

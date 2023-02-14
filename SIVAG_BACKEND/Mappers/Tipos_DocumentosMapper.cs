using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class Tipos_DocumentosMapper
    {
        public static Tipos_DocumentosDTO ToTipos_DocumentosDTO(this Tipos_DocumentosDomain tiposDocumentos)
        {
            return new Tipos_DocumentosDTO
            {
                Tipo_Documento = tiposDocumentos.Tipo_Documento,
                Descripcion = tiposDocumentos.Descripcion,
                Abreviatura = tiposDocumentos.Abreviatura,
                Estado = tiposDocumentos.Estado
            };
        }   
        
        // Default Tipos_DocumentosDomain
        public static Tipos_DocumentosDomain ToTipos_DocumentosDomain(this Tipos_DocumentosDTO tiposDocumentos)
        {
            return new Tipos_DocumentosDomain
            {
                Tipo_Documento = tiposDocumentos.Tipo_Documento,
                Descripcion = tiposDocumentos.Descripcion,
                Abreviatura = tiposDocumentos.Abreviatura,
                Estado = tiposDocumentos.Estado
            };
        }
    }
}

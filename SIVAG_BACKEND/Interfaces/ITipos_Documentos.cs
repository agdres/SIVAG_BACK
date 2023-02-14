using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Interfaces
{
    public interface ITipos_Documentos
    {
        Task<List<Tipos_DocumentosDTO>> GetAll_TipoDocumentos();
        Task<bool> Insert_TipoDocumentos(Tipos_DocumentosDTO data);
        Task<bool> Update_TipoDocumentos(Tipos_DocumentosDTO data);
        Task<bool> ChangeEstatus_TipoDocumentos(int idTipDoc);
    }
}

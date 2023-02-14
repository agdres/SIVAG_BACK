using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Interfaces
{
    public interface IBodegas
    {
        Task<List<BodegasDTO>> GetAll_Bodegas();
        Task<bool> Insert_Bodegas(BodegasDTO data);
        Task<bool> Update_Bodegas(BodegasDTO data);
        Task<bool> ChangeEstatus_Bodegas(int idTipDoc);
    }
}

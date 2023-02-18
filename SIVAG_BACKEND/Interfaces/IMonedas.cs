﻿using SIVAG_BACKEND.Interfaces.General;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Interfaces
{
    public interface IMonedas : IEntityRep<MonedasDTO>
    {
        Task<List<MonedasDTO>> GetMonedasActivos();
    }
}

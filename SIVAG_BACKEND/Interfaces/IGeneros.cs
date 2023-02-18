﻿using SIVAG_BACKEND.Interfaces.General;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Interfaces
{
    public interface IGeneros : IEntityRep<GenerosDTO>
    {
        Task<List<GenerosDTO>> GetGenerosActivos();
    }
}
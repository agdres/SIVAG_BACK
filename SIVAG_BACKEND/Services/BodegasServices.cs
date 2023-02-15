using Microsoft.EntityFrameworkCore;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Mappers;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Services
{
    public class BodegasServices : IBodegas
    {
        private readonly SIVAG_Context _Context;
        public  BodegasServices(SIVAG_Context context) 
        {
            _Context = context;
        }

        public async Task<List<BodegasDTO>> GetAll()
        {
            try
            {
                var Bodegas = await this._Context.Bodegas.ToListAsync();
                return Bodegas.Select(BodegasMapper.ToBodegasDTO).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> Insert(BodegasDTO data)
        {
            try
            {
                await _Context.Bodegas.AddAsync(data.ToBodegasDomain());
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Update(BodegasDTO data)
        {
            try
            {
                _Context.Entry(data.ToBodegasDomain()).State = EntityState.Modified;
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> ChangeEstatus(int id)
        {
            try
            {
                var Bodegas = await this._Context.Bodegas.FindAsync(id);
                Bodegas.Estado = !Bodegas.Estado;

                _Context.Entry(Bodegas).State = EntityState.Modified;
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

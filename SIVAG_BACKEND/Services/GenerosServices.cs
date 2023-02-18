using Microsoft.EntityFrameworkCore;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Mappers;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Services
{
    public class GenerosServices : IGeneros
    {
        private readonly SIVAG_Context _Context;
        public GenerosServices(SIVAG_Context context)
        {
            _Context = context;
        }

        public async Task<List<GenerosDTO>> GetAll()
        {
            try
            {
                var TipDocs = await this._Context.Generos.ToListAsync();
                var Res = TipDocs.Select(GenerosMapper.ToGenerosDTO).ToList();
                return Res;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<bool> Insert(GenerosDTO data)
        {
            try
            {
                await _Context.Generos.AddAsync(data.ToGenerosDomain());
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Update(GenerosDTO data)
        {
            try
            {
                _Context.Entry(data.ToGenerosDomain()).State = EntityState.Modified;
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
                var Generos = await this._Context.Generos.FindAsync(id);
                Generos.Estado = !Generos.Estado;

                _Context.Entry(Generos).State = EntityState.Modified;
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<GenerosDTO>> GetGenerosActivos()
        {
            try
            {
                var TipDocs = await this._Context.Generos.Where(x => x.Estado == false).ToListAsync();
                var Res = TipDocs.Select(GenerosMapper.ToGenerosDTO).ToList();
                return Res;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

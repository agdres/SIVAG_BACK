using Microsoft.EntityFrameworkCore;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Mappers;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Services
{
    public class IdiomasServices : IIdiomas
    {
        private readonly SIVAG_Context _Context;
        public IdiomasServices(SIVAG_Context context)
        {
            _Context = context;
        }

        public async Task<List<IdiomasDTO>> GetAll()
        {
            try
            {
                var Idiomas = await this._Context.Idiomas.ToListAsync();
                var Res = Idiomas.Select(IdiomasMapper.ToIdiomasDTO).ToList();
                return Res;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<bool> Insert(IdiomasDTO data)
        {
            try
            {
                await _Context.Idiomas.AddAsync(data.ToIdiomasDomain());
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Update(IdiomasDTO data)
        {
            try
            {
                _Context.Entry(data.ToIdiomasDomain()).State = EntityState.Modified;
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
                var Idiomas = await this._Context.Idiomas.FindAsync(id);
                Idiomas.Estado = !Idiomas.Estado;

                _Context.Entry(Idiomas).State = EntityState.Modified;
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<IdiomasDTO>> GetIdiomasActivos()
        {
            try
            {
                var TipDocs = await this._Context.Idiomas.Where(x => x.Estado == false).ToListAsync();
                var Res = TipDocs.Select(IdiomasMapper.ToIdiomasDTO).ToList();
                return Res;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

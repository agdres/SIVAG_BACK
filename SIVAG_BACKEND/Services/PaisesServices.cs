using Microsoft.EntityFrameworkCore;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Mappers;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Services
{
    public class PaisesServices : IPaises
    {
        private readonly SIVAG_Context _Context;
        public PaisesServices(SIVAG_Context context)
        {
            _Context = context;
        }

        public async Task<List<PaisesDTO>> GetAll()
        {
            try
            {
                var Paises = await this._Context.Paises.ToListAsync();
                var Res = Paises.Select(PaisesMapper.ToPaisesDTO).ToList();
                return Res;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<bool> Insert(PaisesDTO data)
        {
            try
            {
                await _Context.Paises.AddAsync(data.ToPaisesDomain());
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Update(PaisesDTO data)
        {
            try
            {
                _Context.Entry(data.ToPaisesDomain()).State = EntityState.Modified;
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
                var Paises = await this._Context.Paises.FindAsync(id);
                Paises.Estado = !Paises.Estado;

                _Context.Entry(Paises).State = EntityState.Modified;
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<PaisesDTO>> GetPaisesActivos()
        {
            try
            {
                var Paises = await this._Context.Paises.Where(x => x.Estado == false).ToListAsync();
                var Res = Paises.Select(PaisesMapper.ToPaisesDTO).ToList();
                return Res;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

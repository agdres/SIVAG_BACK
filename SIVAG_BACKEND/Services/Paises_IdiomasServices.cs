using Microsoft.EntityFrameworkCore;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Mappers;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Services
{
    public class Paises_IdiomasServices : IPaises_Idiomas
    {
        private readonly SIVAG_Context _Context;
        public Paises_IdiomasServices(SIVAG_Context context)
        {
            _Context = context;
        }

        public async Task<List<Paises_IdiomasDTO>> GetAll()
        {
            return null;
        }

        public async Task<List<Paises_IdiomasDTO>> GetAll_Pais(int Pais)
        {
            try
            {
                var PaisesIdiomas = await this._Context.PaisesIdiosmas.Where(x => x.ID_Pais == Pais).ToListAsync();
                var Res = PaisesIdiomas.Select(Paises_IdiomasMapper.ToPaises_IdiomasDTO).ToList();
                return Res;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<bool> Insert(Paises_IdiomasDTO data)
        {
            try
            {
                await _Context.PaisesIdiosmas.AddAsync(data.ToPaises_IdiomasDomain());
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Update(Paises_IdiomasDTO data)
        {
            try
            {
                _Context.Entry(data.ToPaises_IdiomasDomain()).State = EntityState.Modified;
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
                var PaisesIdiomas = await this._Context.PaisesIdiosmas.FindAsync(id);
                PaisesIdiomas.Estado = !PaisesIdiomas.Estado;

                _Context.Entry(PaisesIdiomas).State = EntityState.Modified;
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Paises_IdiomasDTO>> GetPaises_IdiomasActivos(int Pais)
        {
            try
            {
                var PaisesIdiomas = await this._Context.PaisesIdiosmas.Where(x => x.ID_Pais == Pais && x.Estado == false).ToListAsync();
                var Res = PaisesIdiomas.Select(Paises_IdiomasMapper.ToPaises_IdiomasDTO).ToList();
                return Res;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

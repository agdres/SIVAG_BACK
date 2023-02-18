using Microsoft.EntityFrameworkCore;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Mappers;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Services
{
    public class Monedas_PaisesServices : IMonedas_Paises
    {
        private readonly SIVAG_Context _Context;
        public Monedas_PaisesServices(SIVAG_Context context)
        {
            _Context = context;
        }

        public async Task<List<Monedas_PaisesDTO>> GetAll()
        {
            return null;
        }

        public async Task<List<Monedas_PaisesDTO>> GetAll_Pais(int Pais)
        {
            try
            {
                var MonedasPaises = await this._Context.MonedaPais.Where(x => x.ID_Pais ==  Pais).ToListAsync();
                var Res = MonedasPaises.Select(Monedas_PaisesMapper.ToMonedas_PaisesDTO).ToList();
                return Res;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<bool> Insert(Monedas_PaisesDTO data)
        {
            try
            {
                await _Context.MonedaPais.AddAsync(data.ToMonedas_PaisesDomain());
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Update(Monedas_PaisesDTO data)
        {
            try
            {
                _Context.Entry(data.ToMonedas_PaisesDomain()).State = EntityState.Modified;
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
                var MonedasPaises = await this._Context.MonedaPais.FindAsync(id);
                MonedasPaises.Estado = !MonedasPaises.Estado;

                _Context.Entry(MonedasPaises).State = EntityState.Modified;
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Monedas_PaisesDTO>> GetMonedas_PaisesActivos(int Pais)
        {
            try
            {
                var MonedasPaises = await this._Context.MonedaPais.Where(x => x.ID_Pais== Pais && x.Estado == false).ToListAsync();
                var Res = MonedasPaises.Select(Monedas_PaisesMapper.ToMonedas_PaisesDTO).ToList();
                return Res;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

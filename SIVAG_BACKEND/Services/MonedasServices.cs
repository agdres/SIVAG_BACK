using Microsoft.EntityFrameworkCore;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Mappers;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Services
{
    public class MonedasServices : IMonedas
    {
        private readonly SIVAG_Context _Context;
        public MonedasServices(SIVAG_Context context)
        {
            _Context = context;
        }

        public async Task<List<MonedasDTO>> GetAll()
        {
            try
            {
                var Monedas = await this._Context.Monedas.ToListAsync();
                var Res = Monedas.Select(MonedasMapper.ToMonedasDTO).ToList();
                return Res;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<bool> Insert(MonedasDTO data)
        {
            try
            {
                await _Context.Monedas.AddAsync(data.ToMonedasDomain());
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Update(MonedasDTO data)
        {
            try
            {
                _Context.Entry(data.ToMonedasDomain()).State = EntityState.Modified;
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
                var Monedas = await this._Context.Monedas.FindAsync(id);
                Monedas.Estado = !Monedas.Estado;

                _Context.Entry(Monedas).State = EntityState.Modified;
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

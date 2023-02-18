using Microsoft.EntityFrameworkCore;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Mappers;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Services
{
    public class Formas_PagoServices : IFormas_Pago
    {
        private readonly SIVAG_Context _Context;
        public Formas_PagoServices(SIVAG_Context context)
        {
            _Context = context;
        }
        public async Task<List<Formas_PagoDTO>> GetFormasPagosActivos()
        {
            try
            {
                var FormasPago = await this._Context.FormasPago.Where(x => x.Estado == false).ToListAsync();
                var Res = FormasPago.Select(Formas_PagoMapper.ToFormas_PagoDTO).ToList();
                return Res;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<Formas_PagoDTO>> GetAll()
        {
            try
            {
                var FormasPago = await this._Context.FormasPago.ToListAsync();
                var Res = FormasPago.Select(Formas_PagoMapper.ToFormas_PagoDTO).ToList();
                return Res;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<bool> Insert(Formas_PagoDTO data)
        {
            try
            {
                await _Context.FormasPago.AddAsync(data.ToFormas_PagoDomain());
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Update(Formas_PagoDTO data)
        {
            try
            {
                _Context.Entry(data.ToFormas_PagoDomain()).State = EntityState.Modified;
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
                var FormasPago = await this._Context.FormasPago.FindAsync(id);
                FormasPago.Estado = !FormasPago.Estado;

                _Context.Entry(FormasPago).State = EntityState.Modified;
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

using Microsoft.EntityFrameworkCore;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Mappers;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Services
{
    public class Medios_PagoService : IMedios_Pago
    {
        private readonly SIVAG_Context _Context;
        public Medios_PagoService(SIVAG_Context context)
        {
            _Context = context;
        }

        public async Task<List<Medios_PagoDTO>> GetFormasPagosActivos()
        {
            try
            {
                var MediosPago = await this._Context.MediosPago.Where(x => x.Estado == false).ToListAsync();
                var Res = MediosPago.Select(Medios_PagoMapper.ToMedios_PagoDTO).ToList();
                return Res;
            }
            catch (Exception)
            {

                throw;
            }
        } 

        public async Task<List<Medios_PagoDTO>> GetAll()
        {
            try
            {
                var MediosPago = await this._Context.MediosPago.ToListAsync();
                var Res = MediosPago.Select(Medios_PagoMapper.ToMedios_PagoDTO).ToList();
                return Res;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<bool> Insert(Medios_PagoDTO data)
        {
            try
            {
                await _Context.MediosPago.AddAsync(data.ToMedios_PagoDomain());
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Update(Medios_PagoDTO data)
        {
            try
            {
                _Context.Entry(data.ToMedios_PagoDomain()).State = EntityState.Modified;
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
                var MediosPago = await this._Context.MediosPago.FindAsync(id);
                MediosPago.Estado = !MediosPago.Estado;

                _Context.Entry(MediosPago).State = EntityState.Modified;
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

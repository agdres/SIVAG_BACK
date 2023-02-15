using Microsoft.EntityFrameworkCore;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Interfaces;

namespace SIVAG_BACKEND.Services
{
    public class MensajesServices : IMensajes
    {
        private readonly SIVAG_Context _Context;
        public MensajesServices(SIVAG_Context context) 
        {
            _Context = context;
        }
        public async Task<List<MensajesDomain>> GetAll()
        {
            try
            {
                var Mensajes = await this._Context.Mensajes.ToListAsync();
                return Mensajes;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> Insert(MensajesDomain data)
        {
            try
            {
                await _Context.Mensajes.AddAsync(data);
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Update(MensajesDomain data)
        {
            try
            {
                _Context.Entry(data).State = EntityState.Modified;
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
                var Mensajes = await this._Context.Mensajes.FindAsync(id);
                Mensajes.Estado = !Mensajes.Estado;

                _Context.Entry(Mensajes).State = EntityState.Modified;
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

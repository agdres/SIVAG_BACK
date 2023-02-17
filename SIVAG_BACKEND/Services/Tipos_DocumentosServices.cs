using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Interfaces;
using Microsoft.EntityFrameworkCore;
using SIVAG_BACKEND.Mappers;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Services
{
    public class Tipos_DocumentosServices : ITipos_Documentos
    {
        private readonly SIVAG_Context _Context;
        public Tipos_DocumentosServices(SIVAG_Context context)
        {
            _Context = context;
        }

        public async Task<List<Tipos_DocumentosDTO>> GetAll()
        {
            try
            {
                var TipDocs = await this._Context.TiposDocumentos.ToListAsync();
                var Res = TipDocs.Select(Tipos_DocumentosMapper.ToTipos_DocumentosDTO).ToList();
                return Res;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<bool> Insert(Tipos_DocumentosDTO data)
        {
            try
            {
                await _Context.TiposDocumentos.AddAsync(data.ToTipos_DocumentosDomain());
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Update(Tipos_DocumentosDTO data)
        {
            try
            {
                _Context.Entry(data.ToTipos_DocumentosDomain()).State = EntityState.Modified;
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
                var TipDoc = await this._Context.TiposDocumentos.FindAsync(id);
                TipDoc.Estado = !TipDoc.Estado;

                _Context.Entry(TipDoc).State = EntityState.Modified;
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Tipos_DocumentosDTO>> GetTipDocActivos()
        {
            try
            {
                var TipDocs = await this._Context.TiposDocumentos.Where(x => x.Estado == false).ToListAsync();
                var Res = TipDocs.Select(Tipos_DocumentosMapper.ToTipos_DocumentosDTO).ToList();
                return Res;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

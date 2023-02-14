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
        public async Task<List<Tipos_DocumentosDTO>> GetAll_TipoDocumentos()
        {
            var TipDocs = await this._Context.TiposDocumentos.ToListAsync();
            var Res = TipDocs.Select(Tipos_DocumentosMapper.ToTipos_DocumentosDto).ToList();
            return Res;
        }

        public async Task<bool> Insert_TipoDocumentos(Tipos_DocumentosDTO data)
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

        public async Task<bool> Update_TipoDocumentos(Tipos_DocumentosDTO data)
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

        public async Task<bool> ChangeEstatus_TipoDocumentos(int idTipDoc)
        {
            try
            {
                var TipDoc = await this._Context.TiposDocumentos.FindAsync(idTipDoc);
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
    }
}

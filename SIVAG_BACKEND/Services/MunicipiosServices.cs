using Microsoft.EntityFrameworkCore;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Mappers;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Services
{
    public class MunicipiosServices : IMunicipios
    {
        private readonly SIVAG_Context _Context;
        public MunicipiosServices(SIVAG_Context context)
        {
            _Context = context;
        }

        public async Task<List<MunicipiosDTO>> GetAll()
        {
            try
            {
                var Municipios = await this._Context.Municipios.ToListAsync();
                var Res = Municipios.Select(MunicipiosMapper.ToMunicipiosDTO).ToList();
                return Res;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> Insert(MunicipiosDTO data)
        {
            try
            {
                await _Context.Municipios.AddAsync(data.ToMunicipiosDomain());
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Update(MunicipiosDTO data)
        {
            try
            {
                _Context.Entry(data.ToMunicipiosDomain()).State = EntityState.Modified;
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
                var Municipios = await this._Context.Municipios.FindAsync(id);
                Municipios.Estado = !Municipios.Estado;

                _Context.Entry(Municipios).State = EntityState.Modified;
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<MunicipiosDTO>> GetMunicipiosActivos(int Departamento)
        {
            try
            {
                var Municipios = await this._Context.Municipios.Where(x => x.ID_Departamento == Departamento && x.Estado == false).ToListAsync();
                var Res = Municipios.Select(MunicipiosMapper.ToMunicipiosDTO).ToList();
                return Res;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

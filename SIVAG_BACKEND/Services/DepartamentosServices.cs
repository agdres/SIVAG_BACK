using Microsoft.EntityFrameworkCore;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Mappers;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Services
{
    public class DepartamentosServices : IDepartamentos
    {
        private readonly SIVAG_Context _Context;
        public DepartamentosServices(SIVAG_Context context)
        {
            _Context = context;
        }

        public async Task<List<DepartamentosDTO>> GetAll()
        {
            try
            {
                var Departamentos = await this._Context.Departamentos.ToListAsync();
                var Res = Departamentos.Select(DepartamentosMapper.ToDepartamentosDTO).ToList();
                return Res;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<bool> Insert(DepartamentosDTO data)
        {
            try
            {
                await _Context.Departamentos.AddAsync(data.ToDepartamentosDomain());
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Update(DepartamentosDTO data)
        {
            try
            {
                _Context.Entry(data.ToDepartamentosDomain()).State = EntityState.Modified;
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
                var Departamentos = await this._Context.Departamentos.FindAsync(id);
                Departamentos.Estado = !Departamentos.Estado;

                _Context.Entry(Departamentos).State = EntityState.Modified;
                await _Context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<DepartamentosDTO>> GetDepartamentosActivos(int Pais)
        {
            try
            {
                var Departamentos = await this._Context.Departamentos.Where(x => x.ID_Pais == Pais && x.Estado == false).ToListAsync();
                var Res = Departamentos.Select(DepartamentosMapper.ToDepartamentosDTO).ToList();
                return Res;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

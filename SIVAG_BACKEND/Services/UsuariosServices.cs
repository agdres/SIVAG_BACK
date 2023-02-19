using Microsoft.EntityFrameworkCore;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Mappers;
using SIVAG_BACKEND.Models.API_Response;
using SIVAG_BACKEND.Utilities;

namespace SIVAG_BACKEND.Services
{
    public class UsuariosServices : IUsuarios
    {
        private readonly SIVAG_Context _Context;
        public UsuariosServices(SIVAG_Context context)
        {
            _Context = context;
        }

        public async Task<List<UsuariosDTO>> GetAll()
        {
            return null;
        }

        public async Task<List<UsuariosDTO>> GetAll_Sucursal(int Sucursal)
        {
            try
            {
                var Usuarios = await
                    (
                        from user in this._Context.Usuarios
                        join emple in this._Context.Empleados on user.ID_Empleado equals emple.Empleado
                        where emple.ID_Sucursal == Sucursal
                        select user 
                    ).ToListAsync();
                
                var Res = Usuarios.Select(UsuariosMapper.ToUsuariosDTO).ToList();
                return Res;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public async Task<bool> Insert(UsuariosDTO data)
        {
            try
            {
                data.Clave = PasswordCrypt.Codificacion(data.Clave);

                await _Context.Usuarios.AddAsync(data.ToUsuariosDomain());
                await _Context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> VerificarPass(int Usuario,string Pass)
        {
            try
            {
                var User = await this._Context.Usuarios.FindAsync(Usuario);
                bool verificacion = PasswordCrypt.VerificacionPass(Pass,User.Clave);
                return verificacion;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Update(UsuariosDTO data)
        {
            try
            {
                var Usuario = await this._Context.Usuarios.FindAsync(data.Usuario);
                Usuario.ID_Rol = data.ID_Rol;
                Usuario.Clave = PasswordCrypt.Codificacion(data.Clave);
                Usuario.Principal = data.Principal;
                Usuario.Estado = data.Estado;


                _Context.Entry(Usuario).State = EntityState.Modified;
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
                var Usuarios = await this._Context.Usuarios.FindAsync(id);
                Usuarios.Estado = !Usuarios.Estado;

                _Context.Entry(Usuarios).State = EntityState.Modified;
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

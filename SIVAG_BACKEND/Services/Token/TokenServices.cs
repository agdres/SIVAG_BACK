using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Interfaces.Public;
using SIVAG_BACKEND.Models.API_Response.Public;
using SIVAG_BACKEND.Utilities;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;

namespace SIVAG_BACKEND.Services.Token
{
    public class TokenServices : ILogin
    {

        private readonly SIVAG_Context _Context;
        private readonly AppSettings _AppSettings;


        public TokenServices(SIVAG_Context context, IOptions<AppSettings> appsettings)
        {
            _Context = context;
            _AppSettings = appsettings.Value;
        }

        public async Task<LoginRes> ValidarIngreso(string usuario, string clave)
        {
            try
            {
                LoginRes Res = new LoginRes();
                Res.ms = "";
                Res.token = null;

                var Usuario = await this._Context.Usuarios.Where(x => x.Nombre_Usuario.Equals(usuario)).FirstOrDefaultAsync();
                if (Usuario != null)
                {
                    if (Usuario.Estado == false)
                    {
                        bool verificacion = PasswordCrypt.VerificacionPass(clave, Usuario.Clave);
                        if (verificacion)
                        {
                            var InfoGeneral = await (from user in this._Context.Usuarios
                                                     join emple in this._Context.Empleados on user.ID_Empleado equals emple.Empleado
                                                     where user.Usuario == Usuario.Usuario
                                                     select new {user,emple}
                                                     ).FirstOrDefaultAsync();

                            var Permisos = await (from user in this._Context.Usuarios
                                                  join rol in this._Context.Roles on user.ID_Rol equals rol.Rol
                                                  join perm in this._Context.Permisos on rol.Rol equals perm.ID_Rol
                                                  where perm.Estado == false
                                                  select perm
                                                  ).ToListAsync();

                            LoginDTO model = new LoginDTO();
                            model.isUserx_res = new List<string>()
                            {
                                "N:"+InfoGeneral.emple.Primer_Apellido,// N - Nombre
                                "S:"+InfoGeneral.emple.ID_Sucursal,// S - Sucursal
                                "B:"+InfoGeneral.emple.ID_Bodega,// B - Bodega
                                "E:"+InfoGeneral.emple.Empleado,// E - Empleado
                                "R:"+InfoGeneral.user.ID_Rol,// R - Rol
                                "U:"+InfoGeneral.user.Usuario,// U - Usuario
                            };

                            model.isUsery_m= new List<LoginPermisos>();
                            Permisos.ForEach(x =>
                            {
                                model.isUsery_m.Add(new LoginPermisos
                                {
                                    Componente = x.ID_Componente,
                                    Crear = x.Crear,
                                    Listar = x.Listar,
                                    Actualizar = x.Actualizar,
                                    Deshabilitar = x.Deshabilitar,
                                    Enviar_MsgBod = x.Enviar_MsgBod,
                                    Recibir_MsgBod = x.Recibir_MsgBod,
                                    S_Enviar_MsgBod = x.S_Enviar_MsgBod,
                                    S_Recibir_MsgBod = x.S_Recibir_MsgBod

                                });
                            });

                            Res.ms = null;
                            Res.token = GenerarTokenModel.GenerarJwtToken( _AppSettings.Key.Substring(0,_AppSettings.Key.Length-82), model);
                        }
                        else
                        {
                            Res.ms = "Usuario o contraseña incorrecta";
                        }
                    }
                    else
                    {
                        Res.ms = "Este usuario se encuentra inactivo, verifique con su empleador";
                    }
                }
                else
                {
                    Res.ms = "Usuario o contraseña incorrecta";
                }
                return Res;

            }
            catch (Exception)
            {

                throw;
            }
        }

        

    }
}

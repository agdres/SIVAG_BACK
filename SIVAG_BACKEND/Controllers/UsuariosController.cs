using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SIVAG_BACKEND.Hubs;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Models.API_Response;
using SIVAG_BACKEND.Models.Enums;
using SIVAG_BACKEND.Models;
using SIVAG_BACKEND.Models.API_Auth;
using SIVAG_BACKEND.Mappers;
using SIVAG_BACKEND.Utilities;
using SIVAG_BACKEND.Utilities.Execptions;
using Microsoft.AspNetCore.Authorization;

namespace SIVAG_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarios _Usuarios;
        public UsuariosController
        (
            IUsuarios usuarios
        )
        {
            _Usuarios = usuarios;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsuarios(int Sucursal)
        {
            try
            {
                var Res = await this._Usuarios.GetAll_Sucursal(Sucursal);

                return Ok(new API_Resp<List<UsuariosDTO>>
                {
                    data = Res,
                    Message = (Res != null ? MensajesResController.Result : MensajesResController.Error_Get),
                    StatusCode = (Res != null ? 200 : 400)
                });
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> InsertUsuarios(UsuariosAuth data)
        {
            try
            {
                var Usuario = data.ToUsuariosAuth_DTO();
                Usuario.Fecha_Creacion = DateTime.Now.ToString("yyyy/MM/dd");
                Usuario.Tiempo_Recupera = null;
                var Res = await this._Usuarios.Insert(Usuario);

                return Ok(new API_Resp<bool>
                {
                    data = Res,
                    Message = (Res != false ? MensajesResController.Result : MensajesResController.Error_Post),
                    StatusCode = (Res != false ? 200 : 400)
                });
            }
            catch (Exception ex)
            {
                var Msj = ExceptionEntityModel.HandleException(ex, "usuario");

                return Ok(new API_Resp<bool>
                {
                    data = false,
                    Message = Msj,
                    StatusCode = 400
                });
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUsuarios(string pass, UsuariosAuth data)
        {
            try
            {
                bool Res = false;
                bool Verificado = await this._Usuarios.VerificarPass(data.Usuario,pass);
                if (Verificado)
                {
                    var Usuario = data.ToUsuariosAuth_DTO();
                    Res = await this._Usuarios.Update(Usuario);
                }

                return Ok(new API_Resp<bool>
                {
                    data = Res,
                    Message = (Res != false ? MensajesResController.Result : MensajesResController.Error_Put),
                    StatusCode = (Res != false ? 200 : 400)
                });
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut]
        [Route("ChangeStatus")]
        public async Task<IActionResult> ChangeEstatusUsuarios(int Usuario)
        {
            try
            {
                var Res = await this._Usuarios.ChangeEstatus(Usuario);
             
                return Ok(new API_Resp<bool>
                {
                    data = Res,
                    Message = (Res != false ? MensajesResController.Result : MensajesResController.Error_Get),
                    StatusCode = (Res != false ? 200 : 400)
                });
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}

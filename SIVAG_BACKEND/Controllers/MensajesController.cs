using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Models.API_Response;
using SIVAG_BACKEND.Models;
using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.Enums;
using Microsoft.AspNetCore.Components.Web;

namespace SIVAG_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensajesController : ControllerBase
    {
        private IMensajes _Msj;

        public MensajesController(IMensajes msj)
        {
            _Msj = msj;
        }

        [HttpGet]
        public async Task<IActionResult> GetMensajes() 
        {
            try
            {
                var Res = await this._Msj.GetAll();

                return Ok(new API_Resp<List<MensajesDomain>>
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
        public async Task<IActionResult> PostMensajes(MensajesDomain data)
        {
            try
            {
                var Res = await this._Msj.Insert(data);

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

        [HttpPut]
        public async Task<IActionResult> PutMensajes(MensajesDomain data)
        {
            try
            {
                var Res = await this._Msj.Update(data);

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

        [HttpPut]
        [Route("ChangeStatus")]
        public async Task<IActionResult> ChangeEstatudMensajes(int Mensaje)
        {
            try
            {
                var Res = await this._Msj.ChangeEstatus(Mensaje);

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

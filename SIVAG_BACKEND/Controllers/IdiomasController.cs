using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SIVAG_BACKEND.Hubs;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Models.API_Response;
using SIVAG_BACKEND.Models.Enums;
using SIVAG_BACKEND.Models;
using Microsoft.AspNetCore.Authorization;

namespace SIVAG_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class IdiomasController : ControllerBase
    {
        private readonly IIdiomas _Idiomas;
        private readonly IHubContext<Hub_Generales> _HubGenerales;
        public IdiomasController
        (
            IIdiomas idiomas,
            IHubContext<Hub_Generales> hubGenerales
        )
        {
            _Idiomas = idiomas;
            _HubGenerales = hubGenerales;
        }

        private async void GetIdiomas_Hub()
        {
            try
            {
                var Res = await this._Idiomas.GetIdiomasActivos();
                await this._HubGenerales.Clients.All.SendAsync("GetIdiomas", Res);

            }
            catch (Exception)
            {

            }
        }

        [HttpGet]
        public async Task<IActionResult> GetIdiomas()
        {
            try
            {
                var Res = await this._Idiomas.GetAll();

                return Ok(new API_Resp<List<IdiomasDTO>>
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
        public async Task<IActionResult> InsertTipo_Documento(IdiomasDTO data)
        {
            try
            {
                var Res = await this._Idiomas.Insert(data);

                if (Res)
                {
                    GetIdiomas_Hub();
                }

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
        public async Task<IActionResult> UpdateIdiomas(IdiomasDTO data)
        {
            try
            {
                var Res = await this._Idiomas.Update(data);
                if (Res)
                {
                    GetIdiomas_Hub();
                }
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
        public async Task<IActionResult> ChangeEstatusIdiomas(int Idioma)
        {
            try
            {
                var Res = await this._Idiomas.ChangeEstatus(Idioma);
                if (Res)
                {
                    GetIdiomas_Hub();
                }
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


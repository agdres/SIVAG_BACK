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
    public class Paises_IdiomasController : ControllerBase
    {
        private readonly IPaises_Idiomas _PaisesIdiomas;
        private readonly IHubContext<Hub_Generales> _HubGenerales;
        public Paises_IdiomasController
        (
            IPaises_Idiomas paisesIdiomas,
            IHubContext<Hub_Generales> hubGenerales
        )
        {
            _PaisesIdiomas = paisesIdiomas;
            _HubGenerales = hubGenerales;
        }

        private async void GetPaises_Idiomas_Hub(int Pais)
        {
            try
            {
                var Res = await this._PaisesIdiomas.GetPaises_IdiomasActivos(Pais);
                await this._HubGenerales.Clients.All.SendAsync("GetPaises_Idiomas", Res);

            }
            catch (Exception)
            {

            }
        }

        [HttpGet]
        public async Task<IActionResult> GetPaises_Idiomas(int Pais)
        {
            try
            {
                var Res = await this._PaisesIdiomas.GetAll_Pais(Pais);

                return Ok(new API_Resp<List<Paises_IdiomasDTO>>
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
        public async Task<IActionResult> InserPaises_Idiomas(Paises_IdiomasDTO data)
        {
            try
            {
                var Res = await this._PaisesIdiomas.Insert(data);

                if (Res)
                {
                    GetPaises_Idiomas_Hub(data.ID_Pais);
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
        public async Task<IActionResult> UpdatePaises_Idiomas(Paises_IdiomasDTO data)
        {
            try
            {
                var Res = await this._PaisesIdiomas.Update(data);
                if (Res)
                {
                    GetPaises_Idiomas_Hub(data.ID_Pais);
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
        public async Task<IActionResult> ChangeEstatusPaises_Idiomas(int Idioma,int Pais)
        {
            try
            {
                var Res = await this._PaisesIdiomas.ChangeEstatus(Idioma);
                if (Res)
                {
                    GetPaises_Idiomas_Hub(Pais);
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

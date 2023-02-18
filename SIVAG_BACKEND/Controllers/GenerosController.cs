using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SIVAG_BACKEND.Hubs;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Models.API_Response;
using SIVAG_BACKEND.Models.Enums;
using SIVAG_BACKEND.Models;

namespace SIVAG_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerosController : ControllerBase
    {
        private readonly IGeneros _Generos;
        private readonly IHubContext<Hub_Generales> _HubGenerales;
        public GenerosController
        (
            IGeneros generos,
            IHubContext<Hub_Generales> hubGenerales
        )
        {
            _Generos = generos;
            _HubGenerales = hubGenerales;
        }

        private async void GetGeneros_Hub()
        {
            try
            {
                var Res = await this._Generos.GetGenerosActivos();
                await this._HubGenerales.Clients.All.SendAsync("GetGeneros", Res);

            }
            catch (Exception)
            {

            }
        }

        [HttpGet]
        public async Task<IActionResult> GetGeneros()
        {
            try
            {
                var Res = await this._Generos.GetAll();

                return Ok(new API_Resp<List<GenerosDTO>>
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
        public async Task<IActionResult> InsertGeneros(GenerosDTO data)
        {
            try
            {
                var Res = await this._Generos.Insert(data);

                if (Res)
                {
                    GetGeneros_Hub();
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
        public async Task<IActionResult> UpdateGeneros(GenerosDTO data)
        {
            try
            {
                var Res = await this._Generos.Update(data);
                if (Res)
                {
                    GetGeneros_Hub();
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
        public async Task<IActionResult> ChangeEstatusGeneros(int Genero)
        {
            try
            {
                var Res = await this._Generos.ChangeEstatus(Genero);
                if (Res)
                {
                    GetGeneros_Hub();
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

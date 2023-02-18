using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Models.API_Response;
using SIVAG_BACKEND.Models.Enums;
using SIVAG_BACKEND.Models;
using Microsoft.AspNetCore.SignalR;
using SIVAG_BACKEND.Hubs;

namespace SIVAG_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonedasController : ControllerBase
    {
        private IMonedas _Monedas;
        private readonly IHubContext<Hub_Generales> _HubGenerales;

        public MonedasController
        (
            IMonedas monedas,
            IHubContext<Hub_Generales> hubGenerales
        )
        {
            _Monedas = monedas;
            _HubGenerales = hubGenerales;
        }

        private async void GetMonedas_Hub()
        {
            try
            {
                var Res = await this._Monedas.GetMonedasActivos();
                await this._HubGenerales.Clients.All.SendAsync("GetMonedas", Res);

            }
            catch (Exception)
            {

            }
        }

        [HttpGet]
        public async Task<IActionResult> GetMonedas()
        {
            try
            {
                var Res = await this._Monedas.GetAll();

                return Ok(new API_Resp<List<MonedasDTO>>
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
        public async Task<IActionResult> InsertMonedas(MonedasDTO data)
        {
            try
            {
                var Res = await this._Monedas.Insert(data);
                if (Res)
                {
                    GetMonedas_Hub();
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
        public async Task<IActionResult> UpdateMonedas(MonedasDTO data)
        {
            try
            {
                var Res = await this._Monedas.Update(data);
                if (Res)
                {
                    GetMonedas_Hub();
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
        public async Task<IActionResult> ChangeEstatusMonedas(int Moneda)
        {
            try
            {
                var Res = await this._Monedas.ChangeEstatus(Moneda);
                if (Res)
                {
                    GetMonedas_Hub();
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

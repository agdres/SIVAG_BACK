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
    public class Monedas_PaisesController : ControllerBase
    {
        private readonly IMonedas_Paises _MonedasPaises;
        private readonly IHubContext<Hub_Generales> _HubGenerales;
        public Monedas_PaisesController
        (
            IMonedas_Paises monedasPaise,
            IHubContext<Hub_Generales> hubGenerales
        )
        {
            _MonedasPaises = monedasPaise;
            _HubGenerales = hubGenerales;
        }

        private async void GetMonedas_Paises_Hub(int Pais)
        {
            try
            {
                var Res = await this._MonedasPaises.GetMonedas_PaisesActivos(Pais);
                await this._HubGenerales.Clients.All.SendAsync("GetMonedas_Paises", Res);
            }
            catch (Exception)
            {

            }
        }

        [HttpGet]
        public async Task<IActionResult> GetMonedas_Paises(int Pais)
        {
            try
            {
                var Res = await this._MonedasPaises.GetAll_Pais(Pais);

                return Ok(new API_Resp<List<Monedas_PaisesDTO>>
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
        public async Task<IActionResult> InsertMonedas_Paises(Monedas_PaisesDTO data)
        {
            try
            {
                var Res = await this._MonedasPaises.Insert(data);

                if (Res)
                {
                    GetMonedas_Paises_Hub(data.ID_Pais);
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
        public async Task<IActionResult> UpdateMonedas_Paises(Monedas_PaisesDTO data)
        {
            try
            {
                var Res = await this._MonedasPaises.Update(data);
                if (Res)
                {
                    GetMonedas_Paises_Hub(data.ID_Pais);
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
        public async Task<IActionResult> ChangeEstatusMonedas_Paises(int MonedasPais, int Pais)
        {
            try
            {
                var Res = await this._MonedasPaises.ChangeEstatus(MonedasPais);
                if (Res)
                {
                    GetMonedas_Paises_Hub(Pais);
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


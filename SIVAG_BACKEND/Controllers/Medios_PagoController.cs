using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Models.API_Response;
using SIVAG_BACKEND.Models;
using SIVAG_BACKEND.Models.Enums;
using Microsoft.AspNetCore.SignalR;
using SIVAG_BACKEND.Hubs;

namespace SIVAG_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Medios_PagoController : ControllerBase
    {
        private readonly IMedios_Pago _MediosPago;
        private readonly IHubContext<Hub_Generales> _HubGenerales;

        public Medios_PagoController
        (
            IMedios_Pago mediosPago,
            IHubContext<Hub_Generales> hubGenerales
        )
        {
            _MediosPago = mediosPago;
            _HubGenerales = hubGenerales;
        }

        private async void GetMedios_Pago_Hub()
        {
            try
            {
                var Res = await this._MediosPago.GetFormasPagosActivos();
                await this._HubGenerales.Clients.All.SendAsync("GetMedios_Pago", Res);

            }
            catch (Exception)
            {

            }
        }

        [HttpGet]
        public async Task<IActionResult> GetMedios_Pago()
        {
            try
            {
                var Res = await this._MediosPago.GetAll();

                return Ok(new API_Resp<List<Medios_PagoDTO>>
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
        public async Task<IActionResult> InserMedios_Pago(Medios_PagoDTO data)
        {
            try
            {
                var Res = await this._MediosPago.Insert(data);
                if (Res)
                {
                    GetMedios_Pago_Hub();
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
        public async Task<IActionResult> UpdateMedios_Pago(Medios_PagoDTO data)
        {
            try
            {
                var Res = await this._MediosPago.Update(data);
                if (Res)
                {
                    GetMedios_Pago_Hub();
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
        public async Task<IActionResult> ChangeEstatusMedios_Pago(int MedioPago)
        {
            try
            {
                var Res = await this._MediosPago.ChangeEstatus(MedioPago);
                if (Res)
                {
                    GetMedios_Pago_Hub();
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

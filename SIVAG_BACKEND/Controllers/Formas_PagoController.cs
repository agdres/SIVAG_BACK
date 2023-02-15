using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Models.API_Response;
using SIVAG_BACKEND.Models;
using SIVAG_BACKEND.Models.Enums;

namespace SIVAG_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Formas_PagoController : ControllerBase
    {
        private readonly IFormas_Pago _FormasPago;
        public Formas_PagoController(IFormas_Pago formasPago)
        {
            _FormasPago = formasPago;
        }

        [HttpGet]
        public async Task<IActionResult> GetFormas_Pago()
        {
            try
            {
                var Res = await this._FormasPago.GetAll();

                return Ok(new API_Resp<List<Formas_PagoDTO>>
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
        public async Task<IActionResult> InsertFormas_Pago(Formas_PagoDTO data)
        {
            try
            {
                var Res = await this._FormasPago.Insert(data);
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
        public async Task<IActionResult> UpdateFormas_Pago(Formas_PagoDTO data)
        {
            try
            {
                var Res = await this._FormasPago.Update(data);

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
        [Route("ChangueStatus")]
        public async Task<IActionResult> ChangeEstatusFormas_Pago(int FormaPago)
        {
            try
            {
                var Res = await this._FormasPago.ChangeEstatus(FormaPago);

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

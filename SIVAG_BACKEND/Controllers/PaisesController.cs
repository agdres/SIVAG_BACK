using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Models.API_Response;
using SIVAG_BACKEND.Models.Enums;
using SIVAG_BACKEND.Models;
using Microsoft.AspNetCore.SignalR;
using SIVAG_BACKEND.Hubs;
using Microsoft.AspNetCore.Authorization;

namespace SIVAG_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PaisesController : ControllerBase
    {
        private IPaises _Paises;
        private IHubContext<Hub_Generales> _HubGenerales;

        public PaisesController(IPaises paises,IHubContext<Hub_Generales> hubGenerales)
        {
            _Paises = paises;
            _HubGenerales = hubGenerales;
        }

        private async void GetPaises_Hub()
        {
            try
            {
                var Res = await this._Paises.GetPaisesActivos();
                await this._HubGenerales.Clients.All.SendAsync("GetPaises", Res);

            }
            catch (Exception)
            {

            }
        }

        [HttpGet]
        public async Task<IActionResult> GetPaises()
        {
            try
            {
                var Res = await this._Paises.GetAll();
                
                return Ok(new API_Resp<List<PaisesDTO>>
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
        public async Task<IActionResult> InsertPaises(PaisesDTO data)
        {
            try
            {
                var Res = await this._Paises.Insert(data);
                if (Res)
                {
                    GetPaises_Hub();
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
        public async Task<IActionResult> UpdatePaises(PaisesDTO data)
        {
            try
            {
                var Res = await this._Paises.Update(data);
                if (Res)
                {
                    GetPaises_Hub();
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
        public async Task<IActionResult> ChangeEstatusPaises(int Pais)
        {
            try
            {
                var Res = await this._Paises.ChangeEstatus(Pais);
                if (Res)
                {
                    GetPaises_Hub();
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

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Models.API_Response;
using SIVAG_BACKEND.Models.Enums;
using SIVAG_BACKEND.Models;
using Microsoft.AspNetCore.SignalR;
using SIVAG_BACKEND.Hubs;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SIVAG_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunicipiosController : ControllerBase
    {
        private IMunicipios _Municipios;
        private readonly IHubContext<Hub_Generales> _HubGenerales;

        public MunicipiosController
        (
            IMunicipios municipios,
            IHubContext<Hub_Generales> hubGenerales
        )
        {
            _Municipios = municipios;
            _HubGenerales = hubGenerales;
        }


        private async void GetMunicipios_Hub(int Departamento)
        {
            try
            {
                var Res = await this._Municipios.GetMunicipiosActivos(Departamento);
                await this._HubGenerales.Clients.All.SendAsync("GetMunicipios", Res);
            }
            catch (Exception)
            {

            }
        }

        [HttpGet]
        public async Task<IActionResult> GeMunicipios()
        {
            try
            {
                var Res = await this._Municipios.GetAll();

                return Ok(new API_Resp<List<MunicipiosDTO>>
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
        public async Task<IActionResult> InserMunicipios(MunicipiosDTO data)
        {
            try
            {
                var Res = await this._Municipios.Insert(data);
                if (Res)
                {
                    GetMunicipios_Hub(data.ID_Departamento);
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
        public async Task<IActionResult> UpdateMunicipios(MunicipiosDTO data)
        {
            try
            {
                var Res = await this._Municipios.Update(data);
                if (Res)
                {
                    GetMunicipios_Hub(data.ID_Departamento);
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
        public async Task<IActionResult> ChangeEstatusMunicipios(int Municipio, int Departamento)
        {
            try
            {
                var Res = await this._Municipios.ChangeEstatus(Municipio);
                if (Res)
                {
                    GetMunicipios_Hub(Departamento);
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

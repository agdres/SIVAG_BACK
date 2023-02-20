using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Models.API_Response;
using SIVAG_BACKEND.Models;
using SIVAG_BACKEND.Models.Enums;
using Microsoft.AspNetCore.SignalR;
using SIVAG_BACKEND.Hubs;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.AspNetCore.Authorization;

namespace SIVAG_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DepartamentosController : ControllerBase
    {
        private readonly IDepartamentos _Departamentos;
        private readonly IHubContext<Hub_Generales> _HubGenerales;

        public DepartamentosController(IDepartamentos departamentos,IHubContext<Hub_Generales> hubGenerales)
        {
            _Departamentos = departamentos;
            _HubGenerales = hubGenerales;
        }

        private async void GetDepartamentos_Hub(int Pais)
        {
            try
            {
                var Res = await this._Departamentos.GetDepartamentosActivos(Pais);
                await this._HubGenerales.Clients.All.SendAsync("GetDepartamentos", Res);
            }
            catch (Exception)
            {

            }
        }

        [HttpGet]
        public async Task<IActionResult> GetDepartamentos(int Pais)
        {
            try
            {
                var Res = await this._Departamentos.GetAll_Pais(Pais);

                return Ok(new API_Resp<List<DepartamentosDTO>>
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
        public async Task<IActionResult> InsertDepartamentos(DepartamentosDTO data)
        {
            var Res = await this._Departamentos.Insert(data);
            if (Res)
            {
                GetDepartamentos_Hub(data.ID_Pais);
            }
            return Ok(new API_Resp<bool>
            {
                data = Res,
                Message = (Res != false ? MensajesResController.Result : MensajesResController.Error_Get),
                StatusCode = (Res != false ? 200 : 400)
            });
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDepartamentos(DepartamentosDTO data)
        {
            var Res = await this._Departamentos.Update(data);
            if (Res)
            {
                GetDepartamentos_Hub(data.ID_Pais);
            }
            return Ok(new API_Resp<bool>
            {
                data = Res,
                Message = (Res != false ? MensajesResController.Result : MensajesResController.Error_Get),
                StatusCode = (Res != false ? 200 : 400)
            });
        }

        [HttpPut]
        [Route("ChangeStatus")]
        public async Task<IActionResult> ChangeEstatusDepartamentos(int Departamento, int Pais)
        {
            var Res = await this._Departamentos.ChangeEstatus(Departamento);
            if (Res)
            {
                GetDepartamentos_Hub(Pais);
            }
            return Ok(new API_Resp<bool>
            {
                data = Res,
                Message = (Res != false ? MensajesResController.Result : MensajesResController.Error_Get),
                StatusCode = (Res != false ? 200 : 400)
            });
        }
    }
}

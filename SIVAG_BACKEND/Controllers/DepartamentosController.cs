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
    public class DepartamentosController : ControllerBase
    {
        private readonly IDepartamentos _Departamentos;
        public DepartamentosController(IDepartamentos departamentos)
        {
            _Departamentos = departamentos;
        }

        [HttpGet]
        public async Task<IActionResult> GetDepartamentos()
        {
            try
            {
                var Res = await this._Departamentos.GetAll();

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

            return Ok(new API_Resp<bool>
            {
                data = Res,
                Message = (Res != false ? MensajesResController.Result : MensajesResController.Error_Get),
                StatusCode = (Res != false ? 200 : 400)
            });
        }

        [HttpPut]
        [Route("ChangueStatus")]
        public async Task<IActionResult> ChangeEstatusDepartamentos(int Departamento)
        {
            var Res = await this._Departamentos.ChangeEstatus(Departamento);

            return Ok(new API_Resp<bool>
            {
                data = Res,
                Message = (Res != false ? MensajesResController.Result : MensajesResController.Error_Get),
                StatusCode = (Res != false ? 200 : 400)
            });
        }
    }
}

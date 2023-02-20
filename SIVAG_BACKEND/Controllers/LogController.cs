using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIVAG_BACKEND.Interfaces.Public;
using SIVAG_BACKEND.Models.API_Response;
using SIVAG_BACKEND.Models.Enums;
using SIVAG_BACKEND.Models;
using SIVAG_BACKEND.Models.API_Response.Public;

namespace SIVAG_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly ILogin _Login;
        public LogController(ILogin login) 
        {
            _Login = login;
        }

        [HttpGet]
        public async Task<IActionResult> ValidarUser(string usuario, string clave) 
        {
            try
            {
                var Res = await this._Login.ValidarIngreso(usuario, clave);

                return Ok(new API_Resp<LoginRes>
                {
                    data = Res,
                    Message = (Res.ms == null ? MensajesResController.Result : MensajesResController.Error),
                    StatusCode = (Res != null ? 200 : 400)
                });
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

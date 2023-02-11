using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIVAG_BACKEND.Core.Context;

namespace SIVAG_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tipos_DocumentosController : ControllerBase
    {
        private readonly SIVAG_Context _Context;
        public Tipos_DocumentosController(SIVAG_Context context) 
        {
            _Context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetTipo_Documento()
        {
            var Res = await this._Context.TiposDocumentos.ToListAsync();
            return Ok(Res);
        }
    }
}

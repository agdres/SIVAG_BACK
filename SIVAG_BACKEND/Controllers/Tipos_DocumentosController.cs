using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Mappers;
using SIVAG_BACKEND.Models;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tipos_DocumentosController : ControllerBase
    {
        private readonly ITipos_Documentos _TipDoc;
        public Tipos_DocumentosController(ITipos_Documentos tipDoc) 
        {
            _TipDoc = tipDoc;
        }

        [HttpGet]
        public async Task<IActionResult> GetTipo_Documento()
        {
            var Res = await this._TipDoc.GetAll_TipoDocumentos();

            return Ok(new API_Respones<List<Tipos_DocumentosDTO>>
            {
                data = Res,
                Message = "",
                StatusCode = 200
            });
        }

        [HttpPost]
        public async Task<IActionResult> InsertTipo_Documento(Tipos_DocumentosDTO data)
        {
            var Res = await this._TipDoc.Insert_TipoDocumentos(data);

            return Ok(new API_Respones<bool>
            {
                data = Res,
                Message = "",
                StatusCode = 200
            });
        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateTipo_Documento(Tipos_DocumentosDTO data)
        {
            var Res = await this._TipDoc.Update_TipoDocumentos(data);

            return Ok(new API_Respones<bool>
            {
                data = Res,
                Message = "",
                StatusCode = 200
            });
        } 
        
        [HttpPut]
        [Route("ChangueEstatus")]
        public async Task<IActionResult> ChangeEstatusTipo_Documento(int idTipDoc)
        {
            var Res = await this._TipDoc.ChangeEstatus_TipoDocumentos(idTipDoc);

            return Ok(new API_Respones<bool>
            {
                data = Res,
                Message = "",
                StatusCode = 200
            });
        }
    }
}

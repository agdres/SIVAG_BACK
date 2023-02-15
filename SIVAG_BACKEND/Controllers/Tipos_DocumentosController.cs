﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using SIVAG_BACKEND.Core.Context;
using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Interfaces;
using SIVAG_BACKEND.Mappers;
using SIVAG_BACKEND.Models;
using SIVAG_BACKEND.Models.API_Response;
using SIVAG_BACKEND.Models.Enums;

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
            try
            {
                var Res = await this._TipDoc.GetAll();

                return Ok(new API_Resp<List<Tipos_DocumentosDTO>>
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
        public async Task<IActionResult> InsertTipo_Documento(Tipos_DocumentosDTO data)
        {
            try
            {
                var Res = await this._TipDoc.Insert(data);

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
        public async Task<IActionResult> UpdateTipo_Documento(Tipos_DocumentosDTO data)
        {
            try
            {
                var Res = await this._TipDoc.Update(data);

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
        public async Task<IActionResult> ChangeEstatusTipo_Documento(int TipoDocumento)
        {
            try
            {
                var Res = await this._TipDoc.ChangeEstatus(TipoDocumento);

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

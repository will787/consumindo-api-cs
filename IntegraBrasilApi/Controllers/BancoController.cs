using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using IntegraBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntegraBrasilApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BancoController : ControllerBase
    {
        private readonly IBancoService _bancoService;

        public BancoController(IBancoService bancoService)
        {
            _bancoService = bancoService;
        }

        [HttpGet("busca/{banco}")]
        public async Task<ActionResult> BuscarBanco([FromRoute] string banco){
            var response = await _bancoService.BuscarBanco(banco);
            if(response.CodigoHttp == HttpStatusCode.OK){
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int) response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}
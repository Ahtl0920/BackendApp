using MauiApp1.Api.Services;
using MauiApp1.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbaranController : ControllerBase
    {
        private readonly IAlbaranService _albaranService;

        public AlbaranController(IAlbaranService albaranService)
        {
            _albaranService = albaranService;
        }

        //  Obtener albarán por serie y número de documento (ORIGEN)
        [HttpGet("origen")]
        public async Task<IActionResult> GetAlbaranOrigen(string serie, int numDoc)
        {
            var albaran = await _albaranService.GetAlbaranOrigenAsync(serie, numDoc);
            if (albaran == null)
                return NotFound("Albarán origen no encontrado");

            return Ok(albaran);
        }

        //  Obtener albarán por serie y número de documento (DESTINO)
        [HttpGet("destino")]
        public async Task<IActionResult> GetAlbaranDestino(string serie, int numDoc)
        {
            var albaran = await _albaranService.GetAlbaranDestinoAsync(serie, numDoc);
            if (albaran == null)
                return NotFound("Albarán destino no encontrado");

            return Ok(albaran);
        }
    }
}

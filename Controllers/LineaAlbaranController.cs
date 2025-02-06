using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using MauiApp1.Api.Services;
using MauiApp1.Api.Models;

namespace MauiApp1.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LineaAlbaranController : ControllerBase
    {
        private readonly ILineaAlbaranService _lineaAlbaranService;

        public LineaAlbaranController(ILineaAlbaranService lineaAlbaranService)
        {
            _lineaAlbaranService = lineaAlbaranService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var lineas = await _lineaAlbaranService.GetAllLineasAsync();
            return Ok(lineas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var linea = await _lineaAlbaranService.GetLineaByIdAsync(id);
            return linea == null ? NotFound() : Ok(linea);
        }

        [HttpGet("albaran/{albaranId}")]
        public async Task<IActionResult> GetByAlbaranId(int albaranId)
        {
            var lineas = await _lineaAlbaranService.GetLineasByAlbaranIdAsync(albaranId);
            return Ok(lineas);
        }

        [HttpGet("origen/{albaranId}")]
        public async Task<IActionResult> GetByAlbaranOrigen(int albaranId)
        {
            var lineas = await _lineaAlbaranService.GetLineasByAlbaranOrigenAsync(albaranId);
            return Ok(lineas);
        }

        [HttpGet("destino/{albaranId}")]
        public async Task<IActionResult> GetByAlbaranDestino(int albaranId)
        {
            var lineas = await _lineaAlbaranService.GetLineasByAlbaranDestinoAsync(albaranId);
            return Ok(lineas);
        }

        [HttpPost]
        public async Task<IActionResult> Create(LineaAlbaran linea)
        {
            var createdLinea = await _lineaAlbaranService.AddLineaAsync(linea);
            return CreatedAtAction(nameof(GetById), new { id = createdLinea.Id }, createdLinea);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, LineaAlbaran linea)
        {
            var updated = await _lineaAlbaranService.UpdateLineaAsync(id, linea);
            return updated ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _lineaAlbaranService.DeleteLineaAsync(id);
            return deleted ? NoContent() : NotFound();
        }
    }
}

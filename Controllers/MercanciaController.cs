using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using MauiApp1.Api.Services;
using MauiApp1.Api.Models;

namespace MauiApp1.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MercanciaController : ControllerBase
    {
        private readonly IMercanciaService _mercanciaService;

        public MercanciaController(IMercanciaService mercanciaService)
        {
            _mercanciaService = mercanciaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var mercancias = await _mercanciaService.GetAllMercanciasAsync();
            return Ok(mercancias);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var mercancia = await _mercanciaService.GetMercanciaByIdAsync(id);
            return mercancia == null ? NotFound() : Ok(mercancia);
        }

        [HttpGet("albaran/{albaranId}")]
        public async Task<IActionResult> GetByAlbaranId(int albaranId)
        {
            var mercancias = await _mercanciaService.GetMercanciasByAlbaranIdAsync(albaranId);
            return Ok(mercancias);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Mercancia mercancia)
        {
            var createdMercancia = await _mercanciaService.AddMercanciaAsync(mercancia);
            return CreatedAtAction(nameof(GetById), new { id = createdMercancia.Id }, createdMercancia);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Mercancia mercancia)
        {
            var updated = await _mercanciaService.UpdateMercanciaAsync(id, mercancia);
            return updated ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _mercanciaService.DeleteMercanciaAsync(id);
            return deleted ? NoContent() : NotFound();
        }
    }
}

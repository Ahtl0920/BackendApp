using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using MauiApp1.Api.Services;
using MauiApp1.Api.Models;

namespace MauiApp1.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RepartidorController : ControllerBase
    {
        private readonly IRepartidorService _repartidorService;

        public RepartidorController(IRepartidorService repartidorService)
        {
            _repartidorService = repartidorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var repartidores = await _repartidorService.GetAllRepartidoresAsync();
            return Ok(repartidores);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var repartidor = await _repartidorService.GetRepartidorByIdAsync(id);
            return repartidor == null ? NotFound() : Ok(repartidor);
        }

        [HttpGet("dni/{dni}")]
        public async Task<IActionResult> GetByDni(string dni)
        {
            var repartidor = await _repartidorService.GetRepartidorByDniAsync(dni);
            return repartidor == null ? NotFound() : Ok(repartidor);
        }

        [HttpGet("{repartidorId}/albaranes")]
        public async Task<IActionResult> GetAlbaranesByRepartidor(int repartidorId)
        {
            var albaranes = await _repartidorService.GetAlbaranesByRepartidorAsync(repartidorId);
            return Ok(albaranes);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Repartidor repartidor)
        {
            var createdRepartidor = await _repartidorService.AddRepartidorAsync(repartidor);
            return CreatedAtAction(nameof(GetById), new { id = createdRepartidor.Id }, createdRepartidor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Repartidor repartidor)
        {
            var updated = await _repartidorService.UpdateRepartidorAsync(id, repartidor);
            return updated ? NoContent() : NotFound();
        }
    }
}
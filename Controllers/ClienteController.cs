using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using MauiApp1.Api.Services;
using MauiApp1.Api.Models;

namespace MauiApp1.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var clientes = await _clienteService.GetAllClientesAsync();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cliente = await _clienteService.GetClienteByIdAsync(id);
            return cliente == null ? NotFound() : Ok(cliente);
        }

        [HttpGet("codigo/{codigoCliente}")]
        public async Task<IActionResult> GetByCodigo(string codigoCliente)
        {
            var cliente = await _clienteService.GetClienteByCodigoAsync(codigoCliente);
            return cliente == null ? NotFound() : Ok(cliente);
        }

        [HttpGet("{clienteId}/albaranes")]
        public async Task<IActionResult> GetAlbaranesByCliente(int clienteId)
        {
            var albaranes = await _clienteService.GetAlbaranesByClienteAsync(clienteId);
            return Ok(albaranes);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            var createdCliente = await _clienteService.AddClienteAsync(cliente);
            return CreatedAtAction(nameof(GetById), new { id = createdCliente.Id }, createdCliente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Cliente cliente)
        {
            var updated = await _clienteService.UpdateClienteAsync(id, cliente);
            return updated ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _clienteService.DeleteClienteAsync(id);
            return deleted ? NoContent() : NotFound();
        }
    }
}

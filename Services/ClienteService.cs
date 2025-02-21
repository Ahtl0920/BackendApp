using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MauiApp1.Api.Data;
using MauiApp1.Api.Models;

namespace MauiApp1.Api.Services
{
   /* public class ClienteService : IClienteService
    {
        private readonly AppDbContext _context;

        public ClienteService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Cliente>> GetAllClientesAsync()
        {
            return await _context.Clientes.Include(c => c.Albaranes).ToListAsync();
        }

        public async Task<Cliente?> GetClienteByIdAsync(int id)
        {
            return await _context.Clientes
                .Include(c => c.Albaranes)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Cliente?> GetClienteByCodigoAsync(string codigoCliente)
        {
            return await _context.Clientes
                .Include(c => c.Albaranes)
                .FirstOrDefaultAsync(c => c.CodigoCliente == codigoCliente);
        }

        public async Task<List<Albaran>> GetAlbaranesByClienteAsync(int clienteId)
        {
            var cliente = await _context.Clientes
                .Include(c => c.Albaranes)
                .FirstOrDefaultAsync(c => c.Id == clienteId);

            return cliente?.Albaranes ?? new List<Albaran>();
        }

        public async Task<Cliente> AddClienteAsync(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task<bool> UpdateClienteAsync(int id, Cliente updatedCliente)
        {
            var existingCliente = await _context.Clientes.FindAsync(id);
            if (existingCliente == null) return false;

            existingCliente.CodigoCliente = updatedCliente.CodigoCliente;
            existingCliente.Nombre = updatedCliente.Nombre;
            existingCliente.NIF = updatedCliente.NIF;
            existingCliente.Direccion = updatedCliente.Direccion;
            existingCliente.Telefono = updatedCliente.Telefono;
            existingCliente.Email = updatedCliente.Email;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteClienteAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null) return false;

            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return true;
        }
    }*/
}

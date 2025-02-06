using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MauiApp1.Api.Data;
using MauiApp1.Api.Models;

namespace MauiApp1.Api.Services
{
    public class RepartidorService : IRepartidorService
    {
        private readonly AppDbContext _context;

        public RepartidorService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Repartidor>> GetAllRepartidoresAsync()
        {
            return await _context.Repartidores.Include(r => r.Albaranes).ToListAsync();
        }

        public async Task<Repartidor?> GetRepartidorByIdAsync(int id)
        {
            return await _context.Repartidores
                .Include(r => r.Albaranes)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<Repartidor?> GetRepartidorByDniAsync(string dni)
        {
            return await _context.Repartidores
                .Include(r => r.Albaranes)
                .FirstOrDefaultAsync(r => r.DNI == dni);
        }

        public async Task<List<Albaran>> GetAlbaranesByRepartidorAsync(int repartidorId)
        {
            var repartidor = await _context.Repartidores
                .Include(r => r.Albaranes)
                .FirstOrDefaultAsync(r => r.Id == repartidorId);

            return repartidor?.Albaranes ?? new List<Albaran>();
        }

        public async Task<Repartidor> AddRepartidorAsync(Repartidor repartidor)
        {
            _context.Repartidores.Add(repartidor);
            await _context.SaveChangesAsync();
            return repartidor;
        }

        public async Task<bool> UpdateRepartidorAsync(int id, Repartidor updatedRepartidor)
        {
            var existingRepartidor = await _context.Repartidores.FindAsync(id);
            if (existingRepartidor == null) return false;

            existingRepartidor.Nombre = updatedRepartidor.Nombre;
            existingRepartidor.Apellidos = updatedRepartidor.Apellidos;
            existingRepartidor.Telefono = updatedRepartidor.Telefono;
            existingRepartidor.DNI = updatedRepartidor.DNI;
            existingRepartidor.MatriculaVehiculo = updatedRepartidor.MatriculaVehiculo;
            existingRepartidor.EmpresaTransporte = updatedRepartidor.EmpresaTransporte;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteRepartidorAsync(int id)
        {
            var repartidor = await _context.Repartidores.FindAsync(id);
            if (repartidor == null) return false;

            _context.Repartidores.Remove(repartidor);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

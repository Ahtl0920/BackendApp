using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MauiApp1.Api.Data;
using MauiApp1.Api.Models;

namespace MauiApp1.Api.Services
{
   /* public class MercanciaService : IMercanciaService
    {
        private readonly AppDbContext _context;

        public MercanciaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Mercancia>> GetAllMercanciasAsync()
        {
            return await _context.Mercancias.Include(m => m.Albaran).ToListAsync();
        }

        public async Task<Mercancia?> GetMercanciaByIdAsync(int id)
        {
            return await _context.Mercancias
                .Include(m => m.Albaran)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<List<Mercancia>> GetMercanciasByAlbaranIdAsync(int albaranId)
        {
            return await _context.Mercancias
                .Where(m => m.AlbaranId == albaranId)
                .Include(m => m.Albaran)
                .ToListAsync();
        }

        public async Task<Mercancia> AddMercanciaAsync(Mercancia mercancia)
        {
            _context.Mercancias.Add(mercancia);
            await _context.SaveChangesAsync();
            return mercancia;
        }

        public async Task<bool> UpdateMercanciaAsync(int id, Mercancia updatedMercancia)
        {
            var existingMercancia = await _context.Mercancias.FindAsync(id);
            if (existingMercancia == null) return false;

            // Actualiza cada campo
            existingMercancia.Descripcion = updatedMercancia.Descripcion;
            existingMercancia.Cantidad = updatedMercancia.Cantidad;
            existingMercancia.CodigoArticulo = updatedMercancia.CodigoArticulo;
            existingMercancia.Estado = updatedMercancia.Estado;
            existingMercancia.Marca = updatedMercancia.Marca;
            existingMercancia.Modelo = updatedMercancia.Modelo;
            existingMercancia.Referencia = updatedMercancia.Referencia;
            existingMercancia.Bultos = updatedMercancia.Bultos;
            existingMercancia.Largo = updatedMercancia.Largo;
            existingMercancia.Ancho = updatedMercancia.Ancho;
            existingMercancia.Alto = updatedMercancia.Alto;
            existingMercancia.Peso = updatedMercancia.Peso;
            existingMercancia.Contenido = updatedMercancia.Contenido;
            existingMercancia.NumeroSerie = updatedMercancia.NumeroSerie;
            existingMercancia.AlbaranId = updatedMercancia.AlbaranId;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteMercanciaAsync(int id)
        {
            var mercancia = await _context.Mercancias.FindAsync(id);
            if (mercancia == null) return false;

            _context.Mercancias.Remove(mercancia);
            await _context.SaveChangesAsync();
            return true;
        }
    }*/
}

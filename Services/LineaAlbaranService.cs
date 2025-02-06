using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MauiApp1.Api.Data;
using MauiApp1.Api.Models;

namespace MauiApp1.Api.Services
{
    public class LineaAlbaranService : ILineaAlbaranService
    {
        private readonly AppDbContext _context;

        public LineaAlbaranService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<LineaAlbaran>> GetAllLineasAsync()
        {
            return await _context.LineasAlbaranes.ToListAsync();
        }

        public async Task<LineaAlbaran?> GetLineaByIdAsync(int id)
        {
            return await _context.LineasAlbaranes.FindAsync(id);
        }

        public async Task<List<LineaAlbaran>> GetLineasByAlbaranIdAsync(int albaranId)
        {
            return await _context.LineasAlbaranes
                .Where(l => l.AlbaranId == albaranId)
                .ToListAsync();
        }

        public async Task<List<LineaAlbaran>> GetLineasByAlbaranOrigenAsync(int albaranId)
        {
            return await _context.LineasAlbaranes
                .Where(l => l.AlbaranId == albaranId && l.Estado == "ORIGEN")
                .ToListAsync();
        }

        public async Task<List<LineaAlbaran>> GetLineasByAlbaranDestinoAsync(int albaranId)
        {
            return await _context.LineasAlbaranes
                .Where(l => l.AlbaranId == albaranId && l.Estado == "DESTINO")
                .ToListAsync();
        }

        public async Task<LineaAlbaran> AddLineaAsync(LineaAlbaran linea)
        {
            _context.LineasAlbaranes.Add(linea);
            await _context.SaveChangesAsync();
            return linea;
        }

        public async Task<bool> UpdateLineaAsync(int id, LineaAlbaran updatedLinea)
        {
            var existingLinea = await _context.LineasAlbaranes.FindAsync(id);
            if (existingLinea == null) return false;

            existingLinea.CodigoArticulo = updatedLinea.CodigoArticulo;
            existingLinea.Unidades = updatedLinea.Unidades;
            existingLinea.Estado = updatedLinea.Estado;
            existingLinea.Marca = updatedLinea.Marca;
            existingLinea.Modelo = updatedLinea.Modelo;
            existingLinea.Referencia = updatedLinea.Referencia;
            existingLinea.Bultos = updatedLinea.Bultos;
            existingLinea.Largo = updatedLinea.Largo;
            existingLinea.Ancho = updatedLinea.Ancho;
            existingLinea.Alto = updatedLinea.Alto;
            existingLinea.Peso = updatedLinea.Peso;
            existingLinea.Contenido = updatedLinea.Contenido;
            existingLinea.NumeroSerie = updatedLinea.NumeroSerie;
            existingLinea.AlbaranId = updatedLinea.AlbaranId;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteLineaAsync(int id)
        {
            var linea = await _context.LineasAlbaranes.FindAsync(id);
            if (linea == null) return false;

            _context.LineasAlbaranes.Remove(linea);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

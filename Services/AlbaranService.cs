using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MauiApp1.Api.Data;
using MauiApp1.Api.Models;

namespace MauiApp1.Api.Services
{
    public class AlbaranService : IAlbaranService
    {
        private readonly AppDbContext _context;

        public AlbaranService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Albaran?> GetAlbaranOrigenAsync(string serie, int numDoc)
        {
            return await _context.Albaranes.FirstOrDefaultAsync(a => a.Serie == serie && a.NumDoc == numDoc);
        }

        public async Task<Albaran?> GetAlbaranDestinoAsync(string serie, int numDoc)
        {
            return await _context.Albaranes.FirstOrDefaultAsync(a => a.Serie == serie && a.NumDoc == numDoc);
        }

        public async Task<List<Albaran>> GetAllAlbaranesAsync()
        {
            return await _context.Albaranes.ToListAsync();
        }

        public async Task<bool> AddAlbaranAsync(Albaran albaran)
        {
            _context.Albaranes.Add(albaran);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateAlbaranOrigenAsync(int albaranId, Albaran updatedData)
        {
            var albaran = await _context.Albaranes.FindAsync(albaranId);
            if (albaran == null) return false;

            UpdateAlbaranFields(albaran, updatedData);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateAlbaranDestinoAsync(int albaranId, Albaran updatedData)
        {
            var albaran = await _context.Albaranes.FindAsync(albaranId);
            if (albaran == null) return false;

            UpdateAlbaranFields(albaran, updatedData);
            albaran.DcSellada = updatedData.DcSellada;
            albaran.PendienteRevision = updatedData.PendienteRevision;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAlbaranAsync(int albaranId)
        {
            var albaran = await _context.Albaranes.FindAsync(albaranId);
            if (albaran == null) return false;

            _context.Albaranes.Remove(albaran);
            await _context.SaveChangesAsync();
            return true;
        }

        private void UpdateAlbaranFields(Albaran albaran, Albaran updatedData)
        {
            albaran.Observaciones = updatedData.Observaciones;
            albaran.FechaEfecto = updatedData.FechaEfecto;
            albaran.HoraLlegada = updatedData.HoraLlegada;
            albaran.HoraSalida = updatedData.HoraSalida;
            albaran.HoraLlegada2 = updatedData.HoraLlegada2;
            albaran.HoraSalida2 = updatedData.HoraSalida2;
            albaran.Operarios = updatedData.Operarios;
            albaran.MediosEspeciales = updatedData.MediosEspeciales;
            albaran.Vehiculo = updatedData.Vehiculo;
            albaran.Semirremolque = updatedData.Semirremolque;
            albaran.DcFirmada = updatedData.DcFirmada;
            albaran.NombreRecepcionista = updatedData.NombreRecepcionista;
            albaran.DniRecepcionista = updatedData.DniRecepcionista;
            albaran.Conforme = updatedData.Conforme;
            albaran.MotivoNoConforme = updatedData.MotivoNoConforme;
        }
    }
}

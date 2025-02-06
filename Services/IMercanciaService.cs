using System.Collections.Generic;
using System.Threading.Tasks;
using MauiApp1.Api.Models;

namespace MauiApp1.Api.Services
{
    public interface IMercanciaService
    {
        Task<List<Mercancia>> GetAllMercanciasAsync();
        Task<Mercancia?> GetMercanciaByIdAsync(int id);
        Task<List<Mercancia>> GetMercanciasByAlbaranIdAsync(int albaranId);
        Task<Mercancia> AddMercanciaAsync(Mercancia mercancia);
        Task<bool> UpdateMercanciaAsync(int id, Mercancia updatedMercancia);
        Task<bool> DeleteMercanciaAsync(int id);
    }
}

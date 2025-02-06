using System.Collections.Generic;
using System.Threading.Tasks;
using MauiApp1.Api.Models;

namespace MauiApp1.Api.Services
{
    public interface IRepartidorService
    {
        Task<List<Repartidor>> GetAllRepartidoresAsync();
        Task<Repartidor?> GetRepartidorByIdAsync(int id);
        Task<Repartidor?> GetRepartidorByDniAsync(string dni);
        Task<List<Albaran>> GetAlbaranesByRepartidorAsync(int repartidorId);
        Task<Repartidor> AddRepartidorAsync(Repartidor repartidor);
        Task<bool> UpdateRepartidorAsync(int id, Repartidor updatedRepartidor);
        Task<bool> DeleteRepartidorAsync(int id);
    }
}

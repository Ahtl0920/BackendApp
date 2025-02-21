using System.Collections.Generic;
using System.Threading.Tasks;
using MauiApp1.Api.Models;

namespace MauiApp1.Api.Services
{
    public interface IAlbaranService
    {
        Task<Albaran?> GetAlbaranOrigenAsync(string serie, decimal numDoc);
        Task<Albaran?> GetAlbaranDestinoAsync(string serie, decimal numDoc);
        Task<List<Albaran>> GetAllAlbaranesAsync();
        Task<bool> AddAlbaranAsync(Albaran albaran);
        Task<bool> UpdateAlbaranOrigenAsync(int albaranId, Albaran updatedData);
        Task<bool> UpdateAlbaranDestinoAsync(int albaranId, Albaran updatedData);
        Task<bool> DeleteAlbaranAsync(int albaranId);
    }
}

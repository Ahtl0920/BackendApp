using System.Collections.Generic;
using System.Threading.Tasks;
using MauiApp1.Api.Models;

namespace MauiApp1.Api.Services
{
    public interface ILineaAlbaranService
    {
        Task<List<LineaAlbaran>> GetAllLineasAsync();
        Task<LineaAlbaran?> GetLineaByIdAsync(int id);
        Task<List<LineaAlbaran>> GetLineasByAlbaranIdAsync(int albaranId);
        Task<List<LineaAlbaran>> GetLineasByAlbaranOrigenAsync(int albaranId);
        Task<List<LineaAlbaran>> GetLineasByAlbaranDestinoAsync(int albaranId);
        Task<LineaAlbaran> AddLineaAsync(LineaAlbaran linea);
        Task<bool> UpdateLineaAsync(int id, LineaAlbaran updatedLinea);
        Task<bool> DeleteLineaAsync(int id);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using MauiApp1.Api.Models;

namespace MauiApp1.Api.Services
{
    public interface IClienteService
    {
        Task<List<Cliente>> GetAllClientesAsync();
        Task<Cliente?> GetClienteByIdAsync(int id);
        Task<Cliente?> GetClienteByCodigoAsync(string codigoCliente);
        Task<Cliente> AddClienteAsync(Cliente cliente);
        Task<bool> UpdateClienteAsync(int id, Cliente updatedCliente);
        Task<bool> DeleteClienteAsync(int id);
        Task<List<Albaran>> GetAlbaranesByClienteAsync(int clienteId);
    }
}

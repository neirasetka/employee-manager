using EmployeeManager.Common.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManager.Services.Interfaces
{
    public interface IClientService
    {
        Task<List<ClientDTO>> Get();
        Task<ClientDTO> Insert(ClientDTO request);
        Task<ClientDTO> Update(ClientDTO request, int id);
        Task<ClientDTO> GetClientById(int id);
        Task<ClientDTO> DeleteById(int id);
    }
}
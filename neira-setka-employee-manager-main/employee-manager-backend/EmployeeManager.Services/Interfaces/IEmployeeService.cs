using EmployeeManager.Common.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManager.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDTO>> Get();
        Task<EmployeeDTO> Insert(EmployeeDTO request);
        Task<EmployeeDTO> Update(EmployeeDTO request, int id);
        Task<EmployeeDTO> GetEmployeeById(int id);
        Task<EmployeeDTO> DeleteById(int id);
    }
}
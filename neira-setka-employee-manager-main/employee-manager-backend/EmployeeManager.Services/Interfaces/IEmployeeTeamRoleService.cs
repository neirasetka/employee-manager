using EmployeeManager.Common.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManager.Services.Interfaces
{
    public interface IEmployeeTeamRoleService
    {
        Task<EmployeeTeamRoleDTO> Delete(int id);
        Task<List<EmployeeTeamRoleDTO>> Get();
        Task<EmployeeTeamRoleDTO> Insert(EmployeeTeamRoleDTO request);
        Task<EmployeeTeamRoleDTO> Update(EmployeeTeamRoleDTO request, int id);
        Task <List<EmployeeTeamRoleDTO>> GetETRById(int id);
    }
}
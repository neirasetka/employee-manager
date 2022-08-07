using EmployeeManager.Common.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManager.Services.Interfaces
{
    public interface ITeamRolesService
    {
        Task<TeamRolesDTO> Delete(int id);
        Task<List<TeamRolesDTO>> Get();
        Task<TeamRolesDTO> Insert(TeamRolesDTO request);
        Task<TeamRolesDTO> Update(TeamRolesDTO request, int id);
    }
}
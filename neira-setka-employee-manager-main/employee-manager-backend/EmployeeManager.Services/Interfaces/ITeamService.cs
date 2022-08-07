using EmployeeManager.Common.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManager.Services.Interfaces
{
    public interface ITeamService
    {
        Task<TeamDTO> Delete(int id);
        Task<List<TeamDTO>> Get();
        Task<TeamDTO> Insert(TeamDTO request);
        Task<TeamDTO> Update(TeamDTO request, int id);
        Task<TeamDTO> GetTeamById(int id);
    }
}
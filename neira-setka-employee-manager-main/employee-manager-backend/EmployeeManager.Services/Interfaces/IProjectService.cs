using EmployeeManager.Common.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManager.Services.Interfaces
{
    public interface IProjectService
    {
        Task<ProjectDTO> Delete(int id);
        Task<List<ProjectDTO>> Get();
        Task<ProjectDTO> Insert(ProjectDTO request);
        Task<ProjectDTO> Update(ProjectDTO request, int id);
        Task<ProjectDTO> DeleteById(int id);
        Task<ProjectDTO> GetProjectById(int id);
    }
}
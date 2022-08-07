using EmployeeManager.API.Entities;
using EmployeeManager.Common.DTO;
using EmployeeManager.Infrastructure;
using EmployeeManager.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.Services.Services
{
    public class ProjectService : IProjectService
    {
        private EmployeeContext _context;
        public ProjectService(EmployeeContext context)
        {
            _context = context;
        }
        public async Task<ProjectDTO> DeleteById(int id)
        {
            var entity = await _context.Projects.FirstOrDefaultAsync(x => x.ProjectID == id);
            _context.Projects.Remove(entity);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }

        public async Task<ProjectDTO> Delete(int id)
        {
            var entity = await _context.Projects.FirstOrDefaultAsync(x => x.ProjectID == id);
            _context.Projects.Remove(entity);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }
        public async Task<List<ProjectDTO>> Get()
        {
            var list = await _context.Projects.Include(p=>p.Team).Include(p=>p.Client).ToListAsync();
            var listMap = list.Select(x => MapperDTO(x)).ToList();
            return listMap;
        }

        public async Task<ProjectDTO> Insert(ProjectDTO request)
        {
            var entity = Mapper(request);
            _context.Projects.Add(entity);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }

        public async Task<ProjectDTO> GetProjectById(int id)
        {
            //project project = _context.Projects.Find(id);
            Project project= await _context.Projects.Where(a=>a.ProjectID==id).FirstOrDefaultAsync();

            ProjectDTO project1 = new ProjectDTO()
            {
                ProjectID = project.ProjectID,
                Name = project.Name,
                ClientID = project.ClientID,
                //ClientName = project.Client.BusinessName,
                TeamID = project.TeamID,
                //TeamName = project.Team.Name,
                Status = project.Status,
                ShortDescription = project.ShortDescription,
                BeginDate = project.BeginDate,
                EndDate= project.EndDate,
                PricingValue= project.PricingValue
            };
            return project1;
        }

        public async Task<ProjectDTO> Update(ProjectDTO request, int id)
        {
            var entity = _context.Projects.Find(id);
            entity = Mapper(request);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }
        private ProjectDTO MapperDTO(Project project)
        {
            if (project == null)
                return null;

            var entity = new ProjectDTO();
            entity.ProjectID = project.ProjectID;
            entity.Name = project.Name;
            entity.ClientID = project.ClientID;
            entity.ClientName = project.Client.BusinessName;
            entity.TeamID = project.TeamID;
            entity.TeamName = project.Team.Name;
            entity.Status = project.Status;
            entity.ShortDescription = project.ShortDescription;
            entity.BeginDate = project.BeginDate;
            entity.EndDate = project.EndDate;
            entity.PricingValue = project.PricingValue;
            return entity;
        }
        private Project Mapper(ProjectDTO project)
        {
            if (project == null)
                return null;

            var entity = new Project();
            entity.ProjectID = project.ProjectID;
            entity.Name = project.Name;
            entity.ClientID = project.ClientID;
            entity.TeamID = project.TeamID;
            entity.Status = project.Status;
            entity.ShortDescription = project.ShortDescription;
            entity.BeginDate = project.BeginDate;
            entity.EndDate = project.EndDate;
            entity.PricingValue = project.PricingValue;
            return entity;
        }
    }
}
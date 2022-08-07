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
    public class TeamService : ITeamService
    {
        private EmployeeContext _context;
        private readonly IEmployeeTeamRoleService _employeeTeamRoleService;

        public TeamService(EmployeeContext context,
                           IEmployeeTeamRoleService employeeTeamRoleService)
        {
            _context = context;
            _employeeTeamRoleService = employeeTeamRoleService;
        }
        public async Task<TeamDTO> Delete(int id)
        {
            var entity = await _context.Teams.FirstOrDefaultAsync(x => x.TeamID == id);
            entity.IsDeleted = true;
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }

        public async Task<List<TeamDTO>> Get()
        {
            var list = await _context.Teams.Where(t=>t.IsDeleted==false).ToListAsync();
            var listMap = list.Select(x => MapperDTO(x)).ToList();
            return listMap;
        }

        public async Task<TeamDTO> GetTeamById(int id)
        {
            Team team= await _context.Teams.Where(a=>a.TeamID==id).FirstOrDefaultAsync();

            TeamDTO team1 = new TeamDTO()
            {
                TeamID = team.TeamID,
                WeeklyEngagement=team.WeeklyEngagement,
                Name=team.Name, 
                Status=team.Status,
                Pricing=team.Pricing,
                Amount = team.Amount,
                ProjectID=team.ProjectID,
                IsDeleted=team.IsDeleted,
                Description=team.Description,
                EmployeesTeamID=team.EmployeesTeamID
            };
            team1.EmployeeRoles = await _employeeTeamRoleService.GetETRById(team.TeamID);
            return team1;
        }

        public async Task<TeamDTO> Insert(TeamDTO request)
        {
            var entity = Mapper(request);
            _context.Teams.Add(entity);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }

        public async Task<TeamDTO> Update(TeamDTO request, int id)
        {
            var entity = _context.Teams.Find(id);
            entity = Mapper(request);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }
        private TeamDTO MapperDTO(Team teams)
        {
            if (teams == null)
                return null;

            var entity = new TeamDTO();
            entity.TeamID = teams.TeamID;
            entity.WeeklyEngagement = teams.WeeklyEngagement;
            entity.Name = teams.Name;
            entity.Status = teams.Status;
            entity.Pricing = teams.Pricing;
            entity.Amount = teams.Amount;
            entity.ProjectID = teams.ProjectID;
            entity.IsDeleted = teams.IsDeleted;
            entity.Description = teams.Description;
            entity.EmployeesTeamID = teams.EmployeesTeamID;
            return entity;
        }

        private Team Mapper(TeamDTO teams)
        {
            if (teams == null)
                return null;

            var entity = new Team();
            entity.TeamID = teams.TeamID;
            entity.WeeklyEngagement = teams.WeeklyEngagement;
            entity.Name = teams.Name;
            entity.Status = teams.Status;
            entity.Pricing = teams.Pricing;
            entity.Amount = teams.Amount;
            entity.ProjectID = teams.ProjectID;
            entity.IsDeleted = teams.IsDeleted;
            entity.Description = teams.Description;
            entity.EmployeesTeamID = teams.EmployeesTeamID;
            return entity;
        }
    }
}
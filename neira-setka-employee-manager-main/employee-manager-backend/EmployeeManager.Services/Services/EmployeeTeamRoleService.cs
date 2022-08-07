using EmployeeManager.Common.DTO;
using EmployeeManager.Core.Entities;
using EmployeeManager.Infrastructure;
using EmployeeManager.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.Services.Services
{
    public class EmployeeTeamRoleService : IEmployeeTeamRoleService
    {
        private EmployeeContext _context;
        public EmployeeTeamRoleService(EmployeeContext context)
        {
            _context = context;
        }
        public async Task<EmployeeTeamRoleDTO> Delete(int id)
        {
            var entity = await _context.EmployeeTeamRoles.FirstOrDefaultAsync(x => x.EmployeeTeamRoleID == id);
            _context.EmployeeTeamRoles.Remove(entity);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }

        public async Task<List<EmployeeTeamRoleDTO>> Get()
        {
            var list = await _context.EmployeeTeamRoles.ToListAsync();
            var listMap = list.Select(x => MapperDTO(x)).ToList();
            return listMap;
        }

        public async Task<List<EmployeeTeamRoleDTO>> GetETRById(int id)
        {
            var employeeteamrole = await _context.EmployeeTeamRoles.Where(e => e.EmployeeID == id).Select(e => new EmployeeTeamRoleDTO()
            {
                EmployeeTeamRoleID = e.EmployeeTeamRoleID,
                EmployeeID = e.EmployeeID,
                TeamID = e.TeamID,
                RoleID = e.RoleID,
                TeamName = e.Team.Name,
                EmployeeName = e.Employee.FirstName,
                TeamRolesName = e.TeamRoles.RoleName,
                WorkingHours = e.WorkingHours,
            }).ToListAsync();

            return employeeteamrole;
        }

        public async Task<EmployeeTeamRoleDTO> Insert(EmployeeTeamRoleDTO request)
        {
            var entity = Mapper(request);
            _context.EmployeeTeamRoles.Add(entity);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }

        public async Task<EmployeeTeamRoleDTO> Update(EmployeeTeamRoleDTO request, int id)
        {
            var entity = _context.EmployeeTeamRoles.Find(id);
            entity = Mapper(request);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }
        private EmployeeTeamRoleDTO MapperDTO(EmployeeTeamRole employeeteamrole)
        {
            if (employeeteamrole == null)
                return null;

            var entity = new EmployeeTeamRoleDTO();
            entity.EmployeeTeamRoleID = employeeteamrole.EmployeeTeamRoleID;
            entity.EmployeeID = employeeteamrole.EmployeeID;
            entity.TeamID = employeeteamrole.TeamID;
            entity.RoleID = employeeteamrole.RoleID;
            entity.RoleInTheTeam = employeeteamrole.RoleInTheTeam;
            entity.IsDeleted = employeeteamrole.IsDeleted;
            entity.WorkingHours = employeeteamrole.WorkingHours;
            return entity;
        }

        private EmployeeTeamRole Mapper(EmployeeTeamRoleDTO employeeteamrole)
        {
            if (employeeteamrole == null)
                return null;

            var entity = new EmployeeTeamRole();
            entity.EmployeeTeamRoleID = employeeteamrole.EmployeeTeamRoleID;
            entity.EmployeeID = employeeteamrole.EmployeeID;
            entity.TeamID = employeeteamrole.TeamID;
            entity.RoleID = employeeteamrole.RoleID;
            entity.RoleInTheTeam = employeeteamrole.RoleInTheTeam;
            entity.IsDeleted = employeeteamrole.IsDeleted;
            entity.WorkingHours = employeeteamrole.WorkingHours;
            return entity;
        }
    }
}
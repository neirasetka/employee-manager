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
    public class TeamRolesService : ITeamRolesService
    {
        private EmployeeContext _context;
        public TeamRolesService(EmployeeContext context)
        {
            _context = context;
        }
        public async Task<TeamRolesDTO> Delete(int id)
        {
            var entity = await _context.Roles.FirstOrDefaultAsync(x => x.TeamRolesID == id);
            _context.Roles.Remove(entity);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }

        public async Task<List<TeamRolesDTO>> Get()
        {
            var list = await _context.Roles.ToListAsync();
            var listMap = list.Select(x => MapperDTO(x)).ToList();
            return listMap;
        }

        public async Task<TeamRolesDTO> Insert(TeamRolesDTO request)
        {
            var entity = Mapper(request);
            _context.Roles.Add(entity);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }

        public async Task<TeamRolesDTO> Update(TeamRolesDTO request, int id)
        {
            var entity = _context.Roles.Find(id);
            entity = Mapper(request);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }

        private TeamRolesDTO MapperDTO(TeamRoles roles)
        {
            if (roles == null)
                return null;

            var entity = new TeamRolesDTO();
            entity.TeamRolesID = roles.TeamRolesID;
            entity.RoleName = roles.RoleName;
            return entity;
        }

        private TeamRoles Mapper(TeamRolesDTO roles)
        {
            if (roles == null)
                return null;

            var entity = new TeamRoles();
            entity.TeamRolesID = roles.TeamRolesID;
            entity.RoleName = roles.RoleName;
            return entity;
        }
    }
}
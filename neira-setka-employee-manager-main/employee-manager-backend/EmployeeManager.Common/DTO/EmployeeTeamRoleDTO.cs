using EmployeeManager.API.Entities;

namespace EmployeeManager.Common.DTO
{
    public class EmployeeTeamRoleDTO
    {
        public int EmployeeTeamRoleID { get; set; }
        public int EmployeeID { get; set; }
        public int TeamID { get; set; }
        public int RoleID { get; set; }
        public string EmployeeName { get; set; }
        public string TeamName { get; set; }
        public string TeamRolesName { get; set; }
        public string RoleInTheTeam { get; set; }
        public bool IsDeleted { get; set; }
        public int WorkingHours { get; set; }
    }
}
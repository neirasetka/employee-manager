using EmployeeManager.API.Entities;

namespace EmployeeManager.Core.Entities
{
    public class EmployeeTeamRole
    {
        public int EmployeeTeamRoleID { get; set; }
        public int EmployeeID { get; set; }
        public int TeamID { get; set; }
        public int RoleID { get; set; }
        public Employee Employee { get; set; }
        public Team Team { get; set; }
        public TeamRoles TeamRoles { get; set; }
        public string RoleInTheTeam { get; set; }
        public bool IsDeleted { get; set; }
        public int WorkingHours { get; set; }
    }
}
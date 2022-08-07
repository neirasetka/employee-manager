using EmployeeManager.Core.Entities;
using System.Collections.Generic;

namespace EmployeeManager.API.Entities
{
    public class Team
    {
        public int TeamID { get; set; }
        public int WeeklyEngagement { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public float Pricing { get; set; }
        public int Amount { get; set; }
        public int ProjectID { get; set; }
        public ICollection<Project> Projects { get; set; }
        public bool IsDeleted { get; set; }
        public string Description { get; set; }
        public int EmployeesTeamID { get; set; }
        public List<EmployeeTeamRole> EmployeeRoles { get; set; }
    }
}
using EmployeeManager.API.Entities;

namespace EmployeeManager.Core.Entities
{
    public class ClientProjectTeam
    {
        public int ClientProjectTeamID { get; set; }
        public Client ClientID { get; set; }
        public Project ProjectID { get; set; }
        public Team TeamID { get; set; }
        public bool IsDeleted { get; set; }
    }
}

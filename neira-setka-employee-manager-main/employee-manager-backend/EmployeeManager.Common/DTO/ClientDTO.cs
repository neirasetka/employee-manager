using EmployeeManager.API.Entities;
using EmployeeManager.Core.Enums;
using System.Collections.Generic;

namespace EmployeeManager.Common.DTO
{
    public class ClientDTO
    {
        public int ClientID { get; set; }
        public string BusinessName { get; set; }
        public string ContactName { get; set; }
        public string HomeAddress { get; set; }
        public string Email { get; set; }
        public StatusClient Status { get; set; }
        public int ProjectID { get; set; }
        public bool IsDeleted { get; set; }
        public List<Project> Project { get; set; }
        public string PhoneNumber { get; set; }
        public string ZipCity { get; set; }
        public byte[] Picture { get; set; }
    }
}
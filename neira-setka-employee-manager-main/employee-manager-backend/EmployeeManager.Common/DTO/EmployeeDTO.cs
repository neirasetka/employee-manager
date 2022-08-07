using EmployeeManager.Core.Enums;
using System;

namespace EmployeeManager.Common.DTO
{
    public class EmployeeDTO
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public float ContractedSalary { get; set; }
        public byte[] Picture { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime BirthDate { get; set; }
        public EmployeeStatus Status { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
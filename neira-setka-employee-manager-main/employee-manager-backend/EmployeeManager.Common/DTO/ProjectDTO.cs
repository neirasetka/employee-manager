using System;

namespace EmployeeManager.Common.DTO
{
    public class ProjectDTO
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string Status { get; set; }
        public string ShortDescription { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal PricingValue { get; set; }
    }
}
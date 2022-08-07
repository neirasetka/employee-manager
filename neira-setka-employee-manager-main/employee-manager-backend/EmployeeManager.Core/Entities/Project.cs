using System;

namespace EmployeeManager.API.Entities
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public int TeamID { get; set; }
        public Team Team { get; set; }
        public string Status { get; set; }
        public string ShortDescription { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal PricingValue { get; set; }
    }
}
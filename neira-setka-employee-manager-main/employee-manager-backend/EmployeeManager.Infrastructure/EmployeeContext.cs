using EmployeeManager.API.Entities;
using EmployeeManager.Core.Entities;
using EmployeeManager.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;


namespace EmployeeManager.Infrastructure
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Database=EmployeeManager;Username=postgres;Password=neira123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeTeamRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());
            modelBuilder.ApplyConfiguration(new TeamRolesConfiguration());

        }
        public DbSet<Client> Client { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TeamRoles> Roles { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<ContactUsMessage> ContactUsMessage { get; set; }
        public DbSet<EmployeeTeamRole> EmployeeTeamRoles { get; set; }
    }
}
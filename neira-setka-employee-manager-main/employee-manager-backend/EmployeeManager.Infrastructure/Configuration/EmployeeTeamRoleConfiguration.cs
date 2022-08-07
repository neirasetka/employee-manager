using EmployeeManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManager.Infrastructure.Configuration
{
    public class EmployeeTeamRoleConfiguration : IEntityTypeConfiguration<EmployeeTeamRole>
    {
        public void Configure(EntityTypeBuilder<EmployeeTeamRole> builder)
        {
            builder.ToTable("employee_team_roles");
            builder.Property(x => x.EmployeeTeamRoleID).HasColumnName("employee_team_role_id");
            builder.Property(x => x.EmployeeID).HasColumnName("employee_id");
            builder.Property(x => x.TeamID).HasColumnName("team_id");
            builder.Property(x => x.RoleID).HasColumnName("role_id");
            //builder.Property(x => x.Employee).HasColumnName("employee");
            //builder.Property(x => x.Team).HasColumnName("team");
            //builder.Property(x => x.TeamRoles).HasColumnName("team_roles");
            builder.Property(x => x.RoleInTheTeam).HasColumnName("role_in_the_team");
            builder.Property(x => x.IsDeleted).HasColumnName("is_deleted");
            builder.Property(x => x.WorkingHours).HasColumnName("working_hours");
        }
    }
}
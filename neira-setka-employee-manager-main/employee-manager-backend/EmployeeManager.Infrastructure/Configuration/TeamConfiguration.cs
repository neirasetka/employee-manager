using EmployeeManager.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManager.Infrastructure.Configuration
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("teams");
            builder.Property(x => x.TeamID).HasColumnName("team_id");
            builder.Property(x => x.WeeklyEngagement).HasColumnName("weekly_engagement");
            builder.Property(x => x.Name).HasColumnName("name");
            builder.Property(x => x.Status).HasColumnName("status");
            builder.Property(x => x.Pricing).HasColumnName("pricing");
            builder.Property(x => x.Amount).HasColumnName("amount");
            builder.Property(x => x.ProjectID).HasColumnName("project_id");
            builder.Property(x => x.IsDeleted).HasColumnName("is_deleted");
            builder.Property(x => x.Description).HasColumnName("description");
            builder.Property(x => x.EmployeesTeamID).HasColumnName("employees_team_id");
        }
    }
}
using EmployeeManager.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManager.Infrastructure.Configuration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("projects");
            builder.Property(x => x.ProjectID).HasColumnName("project_id");
            builder.Property(x => x.Name).HasColumnName("name");
            builder.Property(x => x.ClientID).HasColumnName("client_id");
            builder.Property(x => x.TeamID).HasColumnName("team_id");
            builder.Property(x => x.Status).HasColumnName("status");
            builder.Property(x => x.ShortDescription).HasColumnName("short_description");
            builder.Property(x => x.BeginDate).HasColumnName("begin_date");
            builder.Property(x => x.EndDate).HasColumnName("end_date");
            builder.Property(x => x.PricingValue).HasColumnName("pricing_value");
        }
    }
}
using EmployeeManager.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManager.Infrastructure.Configuration
{
    public class TeamRolesConfiguration : IEntityTypeConfiguration<TeamRoles>
    {
        public void Configure(EntityTypeBuilder<TeamRoles> builder)
        {
            builder.ToTable("team_roles");
            builder.Property(x => x.TeamRolesID).HasColumnName("team_roles_id");
            builder.Property(x => x.RoleName).HasColumnName("role_name");
            //builder.Property(x => x.IsDeleted).HasColumnName("is_deleted");
        }
    }
}
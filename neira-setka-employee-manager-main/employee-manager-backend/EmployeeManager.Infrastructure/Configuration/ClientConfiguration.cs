using EmployeeManager.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManager.Infrastructure.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("clients");
            builder.Property(x => x.ClientID).HasColumnName("client_id");
            builder.Property(x => x.BusinessName).HasColumnName("business_name");
            builder.Property(x => x.ContactName).HasColumnName("contact_name");
            builder.Property(x => x.HomeAddress).HasColumnName("home_address");
            builder.Property(x => x.Email).HasColumnName("email");
            builder.Property(x => x.Status).HasColumnName("status");
            builder.Property(x => x.ProjectID).HasColumnName("project_id");
            builder.Property(x => x.IsDeleted).HasColumnName("is_deleted");
            //builder.Property(x => x.Project).HasColumnName("project");
            builder.Property(x => x.PhoneNumber).HasColumnName("phone_number");
            builder.Property(x => x.ZipCity).HasColumnName("zip_city");
            builder.Property(x => x.Picture).HasColumnName("picture");
        }
    }
}
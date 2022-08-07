using EmployeeManager.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManager.Infrastructure.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {   
            builder.ToTable("employees");
            builder.Property(x => x.EmployeeID).HasColumnName("employee_id");
            builder.Property(x => x.FirstName).HasColumnName("first_name");
            builder.Property(x => x.LastName).HasColumnName("last_name");
            builder.Property(x => x.JobTitle).HasColumnName("job_title");
            builder.Property(x => x.ContractedSalary).HasColumnName("contracted_salary");
            builder.Property(x => x.Picture).HasColumnName("picture");
            builder.Property(x => x.BeginDate).HasColumnName("begin_date");
            builder.Property(x => x.EndDate).HasColumnName("end_date");
            builder.Property(x => x.Status).HasColumnName("status");
            builder.Property(x => x.BirthDate).HasColumnName("birth_date");
            builder.Property(x => x.PhoneNumber).HasColumnName("phone_number");
        }
    }
}
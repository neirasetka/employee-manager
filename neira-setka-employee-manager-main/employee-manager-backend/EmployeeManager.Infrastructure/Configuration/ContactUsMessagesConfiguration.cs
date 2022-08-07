using EmployeeManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManager.Infrastructure.Configuration
{
    class ContactUsMessagesConfiguration : IEntityTypeConfiguration<ContactUsMessage>
    {
        public void Configure(EntityTypeBuilder<ContactUsMessage> builder)
        {
            builder.ToTable("contact_us_messages");
            builder.Property(x => x.ContactUsMessageID).HasColumnName("contact_us_message_id");
            builder.Property(x => x.YourName).HasColumnName("your_name");
            builder.Property(x => x.YourEmail).HasColumnName("your_email");
            builder.Property(x => x.YourPhone).HasColumnName("your_phone");
            builder.Property(x => x.YourMessage).HasColumnName("your_message");
        }
    }
}
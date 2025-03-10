using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TDSPK.Infrastructure.Persistence;

namespace TDSPK.Infrastructure.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .ToTable("Users");

            builder
                .HasKey("Id");

            builder
                .Property(u => u.Name)
                .IsRequired();

            builder
                 .Property(u => u.Status)
                 .IsRequired();

        }

        
    }
}

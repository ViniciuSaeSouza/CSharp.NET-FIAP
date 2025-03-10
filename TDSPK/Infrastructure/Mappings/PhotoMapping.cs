using Microsoft.EntityFrameworkCore;
using TDSPK.Infrastructure.Persistence;

namespace TDSPK.Infrastructure.Mappings
{
    public class PhotoMapping : IEntityTypeConfiguration<Photo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Photo> builder)
        {
            builder
                .ToTable("Photos");

            builder
                .HasKey("Id");

            //builder
            //    .Property(p => p.User)
            //    .IsRequired();

            builder
                .Property(p => p.Url)
                .IsRequired();

            builder
                .Property(p => p.Date)
                .IsRequired();
        }
    }
}

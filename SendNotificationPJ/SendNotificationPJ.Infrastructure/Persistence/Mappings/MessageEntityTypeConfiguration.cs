using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SendNotificationPJ.Domain;

namespace SendNotification.Infrastructure.Persistence.Mappings;

public class MessageEntityTypeConfiguration : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.ToTable("MessagesPJ");
        
        builder.HasKey(p => p.Id);

        builder.Property(m => m.Title)
            .IsRequired()
            .HasMaxLength(200);
        
        builder.Property(m => m.Body)
            .IsRequired()
            .HasMaxLength(2000);

        builder.Property(m => m.CreatedAt)
            .IsRequired();
        
        builder.Property(m => m.NotificationType)
            .IsRequired()
            .HasConversion<int>();
        
        builder.Property(m => m.WasSend)
            .IsRequired()
            .HasDefaultValue(false);
        
        builder.HasIndex(m => m.CreatedAt)
            .HasDatabaseName("IX_Messages_CreatedAt");
        
        builder.HasIndex(m => new { m.NotificationType, m.WasSend })
            .HasDatabaseName("IX_Messages_Type_WasSend");
    }
}
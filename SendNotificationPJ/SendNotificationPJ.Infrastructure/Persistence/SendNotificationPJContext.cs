using Microsoft.EntityFrameworkCore;
using SendNotificationPJ.Domain;

namespace SendNotification.Infrastructure.Persistence;

internal class SendNotificationPJContext(DbContextOptions<SendNotificationPJContext> options) : DbContext(options)
{
    public DbSet<Message> Messages { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SendNotificationPJContext).Assembly);
        
        base.OnModelCreating(modelBuilder);
    }
}
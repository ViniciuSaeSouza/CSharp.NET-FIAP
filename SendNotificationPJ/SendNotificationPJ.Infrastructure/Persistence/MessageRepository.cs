using SendNotificationPJ.Domain;

namespace SendNotification.Infrastructure.Persistence;

internal class MessageRepository(SendNotificationPJContext context) : IMessageRepository
{
    public async void SaveAsync(Message message)
    {
        await context.Messages.AddAsync(message);
        await context.SaveChangesAsync();
    }
}
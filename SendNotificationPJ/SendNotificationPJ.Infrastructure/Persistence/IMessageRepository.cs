using SendNotificationPJ.Domain;

namespace SendNotification.Infrastructure.Persistence;

public interface IMessageRepository
{
    void SaveAsync(Message message);
}
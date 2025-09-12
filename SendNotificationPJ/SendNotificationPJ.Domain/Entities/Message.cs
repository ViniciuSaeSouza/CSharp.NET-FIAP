using SendNotificationPJ.Application.Enums;
using SendNotificationPJ.Domain.Exceptions;

namespace SendNotificationPJ.Domain;

public class Message
{
    public Guid Id { get; private set; }
    public string Title { get; private set; }
    public string Body { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public NotificationTypeEnum NotificationType { get; private set; }
    public bool WasSend { get; private set; }
    
    public Message(string title, string body, NotificationTypeEnum notificationType)
    {
        Valid(title, body, notificationType);
        
        Id = Guid.NewGuid();
        Title = title;
        Body = body;
        CreatedAt = DateTime.UtcNow;
        NotificationType = notificationType;
        WasSend = false;
    }

    private void Valid(string title, string body,  NotificationTypeEnum notificationType)
    {
        ValidString(title);
        ValidString(body);
        
        if (!Enum.IsDefined(typeof(NotificationTypeEnum), (int)notificationType))
            throw new DomainException($"Invalid notification type: {(int)notificationType}");
    }

    private void ValidString(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            throw new DomainException($"Text cannot be null or empty {nameof(text)}");
    }
}
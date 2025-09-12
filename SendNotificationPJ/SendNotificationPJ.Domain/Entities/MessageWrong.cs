using SendNotificationPJ.Application.Enums;

namespace SendNotificationPJ.Domain;

public class MessageWrong
{
    public string Title { get; set; }
    public string Body { get; set; }
    public DateTime CreatedAt { get; set; }
    public NotificationTypeEnum NotificationType { get; set; }

}
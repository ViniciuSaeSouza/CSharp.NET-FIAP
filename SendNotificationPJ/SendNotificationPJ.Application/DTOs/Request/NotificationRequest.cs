using System.ComponentModel.DataAnnotations;
using SendNotificationPJ.Application.Enums;

namespace SendNotificationPJ.Application.DTOs.Request;

public class NotificationRequest
{
    public string Text { get; set; }

    public Person Sender { get; set; }

    public Person Recipient { get; set; }
    
    public NotificationTypeEnum NotificationType { get; set; }

    public DateTime Created { get; private set; }

    public DateTime RetryUntil { get; set; }
    
    public NotificationRequest()
    {
        Validate();
        Created = DateTime.Now;
    }

    private void Validate()
    {
        if (!string.IsNullOrEmpty(Text)) throw new ValidationException("Text cannot be null or empty");
    }
}
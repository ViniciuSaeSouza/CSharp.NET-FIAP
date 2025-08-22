using SendNotificationTDSPJ.Application.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendNotificationTDSPJ.Application.DTOS.Requests;

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
        if (!string.IsNullOrEmpty(Text)) throw new ValidationException();
    }

}

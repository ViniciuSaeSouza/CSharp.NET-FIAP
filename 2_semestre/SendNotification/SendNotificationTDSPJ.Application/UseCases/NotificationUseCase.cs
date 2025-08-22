using SendNotificationTDSPJ.Application.DTOS.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendNotificationTDSPJ.Application.UseCases;

public class NotificationUseCase : INotificationUseCase
{
    public void Send(NotificationRequest notificationRequest)
    {
        Console.WriteLine("Eai... Não eai não");
    }
}

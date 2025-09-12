using SendNotificationPJ.Application.DTOs.Request;

namespace SendNotificationPJ.Application.UseCase;

public class NotificationUseCase : INotificationUseCase
{
    public void Send(NotificationRequest request)
    {
       Console.WriteLine("Chegou aquiiii");
    }
}
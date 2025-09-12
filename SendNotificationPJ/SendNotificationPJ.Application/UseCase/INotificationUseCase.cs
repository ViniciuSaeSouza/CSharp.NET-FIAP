using SendNotificationPJ.Application.DTOs.Request;

namespace SendNotificationPJ.Application.UseCase;

public interface INotificationUseCase
{
    void Send(NotificationRequest request);
}
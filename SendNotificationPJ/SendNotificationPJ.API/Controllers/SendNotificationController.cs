using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendNotificationPJ.Application.DTOs.Request;
using SendNotificationPJ.Application.UseCase;


namespace SendNotificationPJ.API.Controllers
{
    [Route("api/v1/send-notification")]
    [ApiController]
    public class SendNotificationController(INotificationUseCase notificationUseCase) : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody] NotificationRequest notificationRequest)
        {
            notificationUseCase.Send(notificationRequest);
        }
    }
}

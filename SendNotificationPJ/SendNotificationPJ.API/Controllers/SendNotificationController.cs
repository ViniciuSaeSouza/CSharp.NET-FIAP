using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendNotificationPJ.Application.DTOs.Request;


namespace SendNotificationPJ.API.Controllers
{
    [Route("api/v1/send-notification")]
    [ApiController]
    public class SendNotificationController : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody] NotificationRequest notificationRequest)
        {
            
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using SendNotificationTDSPJ.Application.DTOS.Requests;
using SendNotificationTDSPJ.Application.UseCases;
using System.Net;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SendNotificationTDSPJ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendNotificationController(INotificationUseCase notificationUseCase) : ControllerBase
    {
        private readonly INotificationUseCase _notificationUseCase = notificationUseCase;

        // POST api/<SendNotificationController>
        [HttpPost]
        public IActionResult Post([FromBody] NotificationRequest notificationRequest)
        {
            _notificationUseCase.Send(notificationRequest);
            return Ok("Ok");
        }
    }
}

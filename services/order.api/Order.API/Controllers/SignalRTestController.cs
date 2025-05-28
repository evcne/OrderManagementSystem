using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Order.API.Hubs;

namespace Order.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SignalRTestController : ControllerBase
    {
        private readonly IHubContext<OrderHub> _hubContext;

        public SignalRTestController(IHubContext<OrderHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendTestMessage([FromBody] string message)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveOrderNotification", message);
            return Ok(new { Status = "Mesaj gönderildi", Message = message });
        }
    }
}

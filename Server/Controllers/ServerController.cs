using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServerController : ControllerBase
{
    [HttpGet("count")]
    public IActionResult GetCount()
    {
        return Ok(Server.GetCount());
    }

    [HttpPost("add")]
    public IActionResult AddToCount([FromBody] int value)
    {
        Server.AddToCount(value);
        return Ok();
    }
}
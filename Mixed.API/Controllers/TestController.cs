using Microsoft.AspNetCore.Mvc;

namespace Mixed.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
  [HttpGet]
  public IActionResult Get()
  {
    return Ok("Controller API");
  }
}

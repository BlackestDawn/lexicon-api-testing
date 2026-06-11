using Microsoft.AspNetCore.Mvc;

namespace Controller.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
  [HttpGet]
  public IActionResult GetStatic()
  {
    return Ok("Hej från Controller API!");
  }

  [HttpGet("{name}")]
  public IActionResult GetDynamic(string name)
  {
    return Ok($"Hej {name}!");
  }
}

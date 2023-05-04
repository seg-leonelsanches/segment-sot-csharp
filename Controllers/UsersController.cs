using Microsoft.AspNetCore.Mvc;

namespace SegmentSoTCSharp.Controllers;

[ApiController]
[Route("users")]
public class UsersController : ControllerBase
{
    private readonly ILogger<UsersController> _logger;

    public UsersController(ILogger<UsersController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "hi")]
    public String Get()
    {
        return "Hi there!";
    }
}

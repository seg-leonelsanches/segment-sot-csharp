using Microsoft.AspNetCore.Mvc;

namespace segment_sot_csharp.Controllers;

[ApiController]
[Route("sot")]
public class SoTController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<SoTController> _logger;

    public SoTController(ILogger<SoTController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<SegmentSoT> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new SegmentSoT
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}

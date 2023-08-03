using Microsoft.AspNetCore.Mvc;

namespace SSP.PlayerService.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GameController  : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<GameController> _logger;

    public GameController(ILogger<GameController> logger)
    {
        _logger = logger;
    }

    
}
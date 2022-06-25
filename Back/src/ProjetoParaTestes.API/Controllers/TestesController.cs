using Microsoft.AspNetCore.Mvc;
using ProjetoParaTestes.API.Models;

namespace ProjetoParaTestes.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestesController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<TestesController> _logger;

    public TestesController(ILogger<TestesController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetTestes")]
    public IEnumerable<Testes> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Testes
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}

using Microsoft.AspNetCore.Mvc;
using ProjetoParaTestes.API.Data;
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

    private readonly DataContext _context;

    public TestesController(DataContext context)
    {
        _context = context;
    }

    [HttpGet(Name = "GetTestes")]
    public IEnumerable<Evento> Get()
    {
        return _context.Eventos;
    }
}

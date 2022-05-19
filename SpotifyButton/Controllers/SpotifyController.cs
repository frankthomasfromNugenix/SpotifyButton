using Microsoft.AspNetCore.Mvc;
using SpotifyButton.Services;

namespace SpotifyButton.Controllers;
[ApiController]
[Route("[controller]")]
public class SpotifyController : Controller
{
    [HttpGet("ping/{name}")]
    public async Task<IActionResult> Ping([FromRoute] string name)
    {
        SpotifyService spotify = new SpotifyService();
        
        return Ok($"PING: {name}");
    }

    [HttpPost("addsong")]
    public async Task<IActionResult> AddSong()
    {

    }
}

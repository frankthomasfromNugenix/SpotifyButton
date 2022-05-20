using Microsoft.AspNetCore.Mvc;
using SpotifyButton.Models;
using SpotifyButton.Services;

namespace SpotifyButton.Controllers;
[ApiController]
[Route("[controller]")]
public class SpotifyController : Controller
{
    private readonly SpotifyService spotifyService;

    public SpotifyController(SpotifyService spotifyService)
    {
        this.spotifyService = spotifyService;
    }

    [HttpGet("ping/{name}")]
    public async Task<IActionResult> Ping([FromRoute] string name)
    {
        
        return Ok($"PING: {name}");
    }

    [HttpPost("addsong")]
    public async Task<IActionResult> AddSong([FromBody] Song newSong)
    {
        spotifyService.AddSong(newSong);
        return Ok();
    }
}

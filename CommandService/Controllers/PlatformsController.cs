using CommandService.Data;
using CommandService.Dtos;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers;

[Route("api/c/[controller]")]
[ApiController]
public class PlatformsController(CommandDbContext context, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<PlatformReadDto>> GetPlatforms()
    {
        Console.WriteLine("--> Getting Platforms from CommandsService");
        var platformItems = context.Platforms.ToList();
        return Ok(mapper.Map<IEnumerable<PlatformReadDto>>(platformItems));
    }

    [HttpPost]
    public ActionResult TestInBoundConnection()
    {
        Console.WriteLine("--> In Bound Post Command Service");
        return Ok("In Bound Test from PlatformsController. Command Service");
    }
}
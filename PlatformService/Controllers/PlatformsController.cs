using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Data;
using PlatformService.Dtos;
using PlatformService.Entities;

namespace PlatformService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlatformsController(PlatformDbContext context, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<PlatformReadDto>> GetPlatforms()
    {
        return Ok(mapper.Map<IEnumerable<PlatformReadDto>>(context.Platforms.ToList()));
    }

    [HttpGet("{id}")]
    public ActionResult<PlatformReadDto> GetPlatform(int id)
    {
        var platform = context.Platforms.Find(id);
        if (platform == null)
        {
            return NotFound();
        }

        return Ok(mapper.Map<PlatformReadDto>(platform));
    }

    [HttpPost]
    public async Task<ActionResult<PlatformReadDto>> CreatePlatform(PlatformCreateDto platformCreateDto)
    {
        var platformModel = mapper.Map<Platform>(platformCreateDto);
        context.Platforms.Add(platformModel);
        await context.SaveChangesAsync();

        var platformReadDto = mapper.Map<PlatformReadDto>(platformModel);

        return CreatedAtAction(nameof(GetPlatform), new { platformReadDto.Id }, platformReadDto);
    }
}
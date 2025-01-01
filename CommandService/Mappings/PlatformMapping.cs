using CommandService.Dtos;
using CommandService.Entities;
using Mapster;

namespace CommandService.Mappings;

public class PlatformMapping : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Platform, PlatformReadDto>();
    }
}
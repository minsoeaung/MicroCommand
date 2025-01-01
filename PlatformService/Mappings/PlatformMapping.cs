using Mapster;
using PlatformService.Dtos;
using PlatformService.Entities;

namespace PlatformService.Mappings;

public class PlatformMapping : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Platform, PlatformReadDto>();
    }
}
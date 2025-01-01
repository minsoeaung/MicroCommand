using Microsoft.EntityFrameworkCore;
using PlatformService.Entities;

namespace PlatformService.Data;

public class PlatformDbContext(DbContextOptions<PlatformDbContext> options) : DbContext(options)
{
    public DbSet<Platform> Platforms { get; set; }
}
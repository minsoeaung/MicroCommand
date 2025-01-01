using CommandService.Entities;
using Microsoft.EntityFrameworkCore;

namespace CommandService.Data;

public class CommandDbContext(DbContextOptions<CommandDbContext> options) : DbContext(options)
{
    public DbSet<Command> Commands { get; set; }
    public DbSet<Platform> Platforms { get; set; }
}
namespace CommandService.Data;

public static class PrepDb
{
    public static void PrepPopulation(IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.CreateScope();
        SeedData(serviceScope.ServiceProvider.GetRequiredService<CommandDbContext>());
    }

    private static void SeedData(CommandDbContext context)
    {
        // context.Database.Migrate();
        Console.WriteLine("--> Must seed later");
    }
}
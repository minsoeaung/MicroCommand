using Mapster;
using Microsoft.EntityFrameworkCore;
using PlatformService.Data;
using PlatformService.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddMapster();
builder.Services.AddMappings();
builder.Services.AddDbContext<PlatformDbContext>(opt =>
    opt.UseNpgsql(builder.Configuration.GetConnectionString("PlatformsConn")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

PrepDb.PrepPopulation(app);

app.Run();
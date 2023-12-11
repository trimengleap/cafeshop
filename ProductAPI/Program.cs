using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductApi;
using CoffeLib;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<IDbContext, SqlDbContext>(optionBuilder
    => { optionBuilder.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")); });
builder.Services.AddTransient<CoffeRepo>();
builder.Services.AddTransient<CoffeService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

MapProductEndpoints(app, "Coffes");

app.Run();

void MapProductEndpoints(WebApplication app, string tag)
{
    app.MapGet("api/coffes", ([FromServices] CoffeService service) 
        => { return service.ReadAll(); }).WithTags(tag);
    app.MapGet("api/coffes/{key}", ([FromServices] CoffeService service, string key) 
        => { return service.Read(key); }).WithTags(tag);
    app.MapPost("api/coffes", ([FromServices] CoffeService service, CoffeCreateReq req) 
        => { return service.Create(req); }).WithTags(tag);
    app.MapPut("api/coffes", ([FromServices] CoffeService service, CoffeUpdateReq req) 
        => { return service.Update(req); }).WithTags(tag);
    app.MapDelete("api/coffes/{key}", ([FromServices] CoffeService service, string key) 
        => { return service.Delete(key); }).WithTags(tag);

}


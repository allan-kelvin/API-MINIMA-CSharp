
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using miminal_api.Interfaces;
using miminal_api.Servicos;
using MiminalApi.DTOs;
using MiminalApi.Infraestrutura.DB;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAdministradorServico, AdministradorServico>();

builder.Services.AddDbContext<DBContexto>(options =>
{
    options.UseMySql
    (
        builder.Configuration.GetConnectionString("mysql"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql"))
     );
});

var app = builder.Build();


app.MapGet("/", () => "MINIMAL API");

app.MapPost("/login", ([FromBody] LoginDTO loginDTO, IAdministradorServico administradorServico) =>
{
    if (administradorServico.Login(loginDTO) != null)
    {
        return Results.Ok("Login com sucesso");
    }
    else
    {
        return Results.Unauthorized();
    }
}); 

app.Run();

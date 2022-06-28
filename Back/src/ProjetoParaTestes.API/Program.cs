using Microsoft.EntityFrameworkCore;
using ProjetoParaTestes.Application;
using ProjetoParaTestes.Application.Contratos;
using ProjetoParaTestes.Persistence;
using ProjetoParaTestes.Persistence.Contextos;
using ProjetoParaTestes.Persistence.Contratos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(
                context => context.UseSqlite(builder.Configuration.GetConnectionString("Default"))
);
builder.Services.AddControllers()
                    .AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling =
                        Newtonsoft.Json.ReferenceLoopHandling.Ignore
                    );

builder.Services.AddScoped<IEventoService, EventoService>();
builder.Services.AddScoped<IGeralPersist, GeralPersist>();
builder.Services.AddScoped<IEventoPersist, EventoPersist>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

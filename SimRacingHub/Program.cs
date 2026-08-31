using Microsoft.EntityFrameworkCore;
using SimRacingHub.Features.Setups.CreateSetup;
using SimRacingHub.Features.Setups.GetSetupById;
using SimRacingHub.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

//1. РЕГИСТРАЦИЯ БАЗЫ ДАННЫХ
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

//2. РЕГИСТРАЦИЯ MEDIATR (CQRS)
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

//3. НАСТРОЙКА SWAGGER (Интерфейс для тестов API)
builder.Services.AddOpenApi();
builder.Services.AddControllers();

var app = builder.Build();

//4. НАСТРОЙКА PIPELINE (Как обрабатываются HTTP-запросы)
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.MapCreateSetupEndpoint();
app.MapGetSetupByIdEndpoint();

app.Run();
using RestApi2.Services;
using RestApi2.Services.Impl;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Singleton não recria o objeto a cada requisicao
builder.Services.AddSingleton<MathService>();

// para recriar o objeto a cada requisicao
builder.Services.AddScoped<IPersonServices, PersonServicesImpl>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

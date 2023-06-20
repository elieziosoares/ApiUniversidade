using apiUniversidade.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext to access PostgreSQL
string connectionString;

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()){
    app.UseSwagger();
    app.UseSwaggerUI();

    
    connectionString = builder.Configuration.GetConnectionString("Azure");
}
else
    connectionString = Environment.GetEnvironmentVariable("Azure", EnvironmentVariableTarget.Process);

builder.Services.AddDbContext<ApiUniversidadeContext>(options => options.UseNpgsql(connectionString));
app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using apiUniversidade.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("PostgreSQL");
builder.Services.AddDbContext<ApiUniversidadeContext>(options => options.UseNpgsql(connectionString));

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddIdentity<IdentityUser,IdentityRole>()
    .AddEntityFrameworkStores<ApiUniversidadeContext>()
    .AddDefaultTokenProviders();

//JWT
//Adiciona o manipulador de autenticação
//Define o Bearer como método
//Valida emissor, audiência e chave
//Valida a assinatura utilizando a chave 
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
            options.TokenValidationParameters = new TokenValidationParameters{
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidAudience = builder.Configuration["TokenConfiguration:Audience"],
                ValidIssuer = builder.Configuration["TokenConfiguration:Issuer"],
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(builder.Configuration["Jwt:key"]))
            });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
/*
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo{Title="APICatalogo",Version="v1"});
    c.AddSecurityDefinition("Bearer",new OpenApiSecurityScheme(){
        Name="Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
        BearerFormat="JWT",
        In=ParameterLocation.Header,
        Description="Header de autorização JWT.\n\n'Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImVsaWV6aW8iLCJJRlJOIjoiVGVjSW5mbyIsImp0aSI6IjVjZTZjYTkzLWYyMjEtNGRmMS1iYmMzLTA1NjVmYjY0NTdhYyIsImV4cCI6MTcwMTc0MDczOCwiaXNzIjoiRWxpZXppbyIsImF1ZCI6IklGUk5fQWx1bm9zIn0.3wcUKNI-zqlMrCqqm8U6N8IdhPaT6NsASpNNKF-MXWM"
    })
}
*/


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()){
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

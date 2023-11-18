using MicroRabbit.Transfer.Data.Context;
using MicroRabbitMQ.Infra.IoC;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TransferDbContext>(options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("TransferDbConnection"));
});

// Before MediatR 12.0.0
//builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

builder.Services.AddMediatR(cfg => 
    cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

DependencyContainer.Register(builder.Services);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Transfer Microservice", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Transfer Microservice V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

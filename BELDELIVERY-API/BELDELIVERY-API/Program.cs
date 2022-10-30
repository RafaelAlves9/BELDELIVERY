using Microsoft.EntityFrameworkCore;
using BELDELIVERY_API.Data;
using BELDELIVERY_API.Controllers;
using BELDELIVERY_API.Domain.Interfaces;
using BELDELIVERY_API.Domain.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BelDeliveryContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BelDeliveryContext"))
);

builder.Services.AddScoped<IClientRepositorie, ClientRepositorie>();
builder.Services.AddScoped<IStoreRepositorie, StoreRepositorie>();
builder.Services.AddScoped<IAdministratorRepositorie, AdministratorRepositorie>();
builder.Services.AddScoped<IClientAddressRepositorie, ClientAddressRepositorie>();
builder.Services.AddScoped<IClientProfileRepositorie, ClientProfileRepositorie>();
builder.Services.AddScoped<IProductRepositorie, ProductRepositorie>();
builder.Services.AddScoped<IStoreAddressRepositorie, StoreAddressRepositorie>();
builder.Services.AddScoped<IStoreProfileRepositorie, StoreProfileRepositorie>();
builder.Services.AddScoped<IStoreRepositorie, StoreRepositorie>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();

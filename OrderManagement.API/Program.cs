using Microsoft.AspNetCore.Mvc;
using OrderManagement.Application.DTOs;
using OrderManagement.Application.Repositories;
using OrderManagement.Domain.Entities;
using OrderManagement.Infrastructure.Factory;
using OrderManagement.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<SqlFactory>();
builder.Services.AddTransient<IProductsRepository, ProductsRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/GetAllProducts/", ([FromServices]IProductsRepository repo) => repo.GetAllProducts());
app.MapGet("/GetProductsById/{id}", ([FromServices] IProductsRepository repo, int id) => repo.GetProductsById(id));
app.MapPost("/InsertProducts/", ([FromServices] IProductsRepository repo, [FromBody] ProductsModel products) => repo.InsertProducts(products));
app.MapDelete("/DeleteProducts/", ([FromServices] IProductsRepository repo, int id) => repo.DeleteProducts(id));
app.MapPut("/UpdateProducts/", ([FromServices] IProductsRepository repo, [FromBody] ProductsDTO products) => repo.UpdateProducts(products));

app.Run();

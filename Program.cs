using Microsoft.EntityFrameworkCore;
using SimpleApi.Data;
using SimpleApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();  // <-- important

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();           // <-- important
    app.UseSwaggerUI();         // <-- important
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

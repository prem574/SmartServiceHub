using SmartServiceHub.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SmartServiceHub.Repository;
using SmartServiceHub.Services;
using AutoMapper;
using SmartServiceHub.Mappings;

var builder = WebApplication.CreateBuilder(args);

// 1. Register DbContext FIRST
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Add AutoMapper
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

// 3. Register repositories and services
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IServiceTypeRepository, ServiceTypeRepository>();
builder.Services.AddScoped<IServiceTypeservice, ServiceTypeService>();

builder.Services.AddScoped<IServiceRequestRepository, ServiceRequestRepository>();
builder.Services.AddScoped<IServiceRequestService, ServiceRequestService>();

// 4. Add Controllers and Swagger (with valid OpenAPI info)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Smart Service Hub API",
        Version = "1.0.0", // REQUIRED FIELD 
        Description = "API for managing users, services, and requests"
    });
});

// 5. Build the app AFTER registering everything
var app = builder.Build();

// 6. Middleware pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Smart Service Hub API V1");
        c.RoutePrefix = "swagger"; // Open Swagger at root URL
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

using FluentValidation;
using Job_Tracker_Platform.Application.Validators;
using Job_Tracker_Platform.Infrustructure;
using Job_Tracker_Platform.Infrustructure.Context;
using Job_Tracker_Platform_project.Middlewares;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Appdbcontext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("Default")));

builder.Services.AddHttpLogging(options =>
{
    options.LoggingFields =
    HttpLoggingFields.RequestMethod |
    HttpLoggingFields.RequestPath |
    HttpLoggingFields.RequestHeaders |
    HttpLoggingFields.RequestBody |
    HttpLoggingFields.ResponseStatusCode |
    HttpLoggingFields.ResponseHeaders |
    HttpLoggingFields.ResponseBody;
});


builder.Services.AddInfrustructureServices();

builder.Services.AddValidatorsFromAssemblyContaining<ValidatorUser>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseHttpLogging();

app.UseAuthorization();

app.UseMiddleware<GlobalExceptionMiddleware>();

app.MapControllers();

app.Run();

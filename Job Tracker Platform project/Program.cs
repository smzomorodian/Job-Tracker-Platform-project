using Job_Tracker_Platform.Application.Interfaces_Repository;
using Job_Tracker_Platform.Application.Service.Company_Service;
using Job_Tracker_Platform.Application.Services.JobApplications;
using Job_Tracker_Platform.Application.User_Service;
using Job_Tracker_Platform.Infrustructure.Context;
using Job_Tracker_Platform.Infrustructure.Repository;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Appdbcontext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("Default")));


builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserSerivce>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IJobRepository, JobRepository>();
builder.Services.AddScoped<IJobService, JobService>();



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

app.UseAuthorization();

app.MapControllers();

app.Run();

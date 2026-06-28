using Job_Tracker_Platform.Application.Interfaces_Repository;
using Job_Tracker_Platform.Application.Service.Company_Service;
using Job_Tracker_Platform.Application.Services.JobApplications;
using Job_Tracker_Platform.Application.User_Service;
using Job_Tracker_Platform.Infrustructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Job_Tracker_Platform.Infrustructure;

public static class DependecyInjector
{
    public static IServiceCollection AddInfrustructureServices(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserService, UserSerivce>();
        services.AddScoped<ICompanyService, CompanyService>();
        services.AddScoped<ICompanyRepository, CompanyRepository>();
        services.AddScoped<IJobRepository, JobRepository>();
        services.AddScoped<IJobService, JobService>();

        return services;
    }
}

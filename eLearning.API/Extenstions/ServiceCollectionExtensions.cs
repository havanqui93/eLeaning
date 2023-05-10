using System;
using System.Configuration;
using eLeaning.Infrastructure.Data;
using eLeaning.Infrastructure.Data.Repository;
using eLearning.API.Services;
using eLearning.API.Services.Interfaces;
using eLearning.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eLearning.API.Extenstions
{
	public static class ServiceCollectionExtensions
	{
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped(typeof(IRepositoryAsync<>), typeof(RepositoryBase<>))
                .AddScoped<IUserRepository, UserRepository>();
        }

        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            return services
                .AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static IServiceCollection AddDatabase(this IServiceCollection services
            , IConfiguration configuration)
        {
            return services.AddDbContext<ElearningDbContext>(options =>
                     options.UseSqlServer(configuration.GetConnectionString("ElearningConnectionString")));
        }

        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            return services
                .AddScoped<IUserService, UserService>();
        }
    }
}


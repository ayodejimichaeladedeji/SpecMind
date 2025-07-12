using SpecMind.Application.InternalServices;

namespace SpecMind.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationServiceDependencies(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ServiceRegistration).Assembly);
            services.AddScoped<IUserService, UserService>();
            //    services.AddValidatorsFromAssemblyContaining<CreateUserValidator>();
            return services;
        }

    }
}
namespace SpecMind.Infrastructure
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServiceDependencies(this IServiceCollection services, IConfiguration configuration)
        {   
            services.AddScoped((s) => new SqlConnection(configuration.GetConnectionString("SpecMindConnectionString")));
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
using Microsoft.Extensions.DependencyInjection;

namespace UTN_Students.BusinessLogic
{
    public static class RegisterServicesExtension
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            services.Scan(scan =>
                    scan
                    .FromCallingAssembly()
                    .AddClasses()
                    .AsMatchingInterface()
                    .WithScopedLifetime());

            return services;
        }
    }
}

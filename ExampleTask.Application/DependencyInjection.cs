using Microsoft.Extensions.DependencyInjection;

namespace ExampleTask.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssemblies(
                typeof(DependencyInjection).Assembly);
                
        });



        return services;
    }
}

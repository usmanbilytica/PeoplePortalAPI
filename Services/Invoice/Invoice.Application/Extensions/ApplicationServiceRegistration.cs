using Microsoft.Extensions.DependencyInjection;

namespace Invoice.Application.Extensions;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        return services;
    }
}

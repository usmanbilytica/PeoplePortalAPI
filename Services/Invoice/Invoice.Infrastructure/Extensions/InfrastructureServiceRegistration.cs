using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Invoice.Infrastructure.Data;

namespace Invoice.Infrastructure.Extensions;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<InvoiceContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("InvoiceConnectionString")));
        return services;
    }
}

using Microsoft.Extensions.DependencyInjection;

namespace Organizer.Application.Extensions;

public static class DependencyInjectionExtension
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}
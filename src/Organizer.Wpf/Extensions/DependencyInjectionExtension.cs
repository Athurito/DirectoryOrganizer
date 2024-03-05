using Microsoft.Extensions.DependencyInjection;

namespace Organizer.Wpf.Extensions;

public static class DependencyInjectionExtension
{
    public static IServiceCollection AddWpf(this IServiceCollection services)
    {
        return services;
    }
}
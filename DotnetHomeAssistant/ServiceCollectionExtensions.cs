using HomeAssistantGenerated;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetHomeAssistant;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddHomeAssistantEntities(this IServiceCollection services)
    {
        services.AddTransient(s => new Entities(s.GetRequiredService<IHaContext>()));
        return services;
    }
    
}
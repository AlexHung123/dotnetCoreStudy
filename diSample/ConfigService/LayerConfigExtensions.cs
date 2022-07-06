using Microsoft.Extensions.DependencyInjection;

namespace ConfigService;

public static class LayerConfigExtensions
{
    public static void AddLayerConfig(this IServiceCollection services){
        services.AddScoped<IConfigReader, LayerConfigReader>();
    }
}

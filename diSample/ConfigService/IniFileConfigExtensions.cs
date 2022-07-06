using ConfigService;

namespace Microsoft.Extensions.DependencyInjection;

public static class IniFileConfigExtensions
{
    public static void AddIniFileConfig(this IServiceCollection service, string filePath){
        service.AddScoped(typeof(IConfigService), s=> new IniFileConfigService{FilePath = filePath});
    }
}

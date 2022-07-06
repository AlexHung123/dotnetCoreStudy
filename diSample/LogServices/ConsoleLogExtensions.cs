namespace Microsoft.Extensions.DependencyInjection;

using LogServices;
public static class ConsoleLogExtensions
{
    public static void AddConsoleLog(this IServiceCollection services){
        services.AddScoped<ILogProvider, ConsoleLogProvider>();
    }
}

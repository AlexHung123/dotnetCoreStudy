// See https://aka.ms/new-console-template for more information
using ConfigService;
using MailServices;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");


ServiceCollection services = new ServiceCollection();
//services.AddScoped(typeof(IConfigService), s=> new IniFileConfigService {FilePath="mail.ini"});
// services.AddScoped<IConfigService,EnvVarConfigService>();
services.AddIniFileConfig("mail.ini");
services.AddLayerConfig();
services.AddScoped<IMailService,MailService>();
//services.AddScoped<ILogProvider,ConsoleLogProvider>();

services.AddConsoleLog();

using(var sp = services.BuildServiceProvider()){
    //root object need to use the serviceLocator
    var mailService = sp.GetRequiredService<IMailService>();
    mailService.Send("Hello", "alex@gmail.com", "hello world");   
}

Console.Read();
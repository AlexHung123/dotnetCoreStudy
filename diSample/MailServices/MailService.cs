using ConfigService;
using LogServices;

namespace MailServices;

public class MailService : IMailService
{

    private readonly ILogProvider _logProvider;
    // private readonly IConfigService _configService;
    private readonly IConfigReader _configService;

    public MailService(ILogProvider logProvider, IConfigReader configService){
        this._logProvider = logProvider;
        this._configService = configService;
    }
    public void Send(string title, string to, string body)
    {
        _logProvider.LogInfo("Ready to send the message");
        _configService.GetValue("UserName");
        System.Console.WriteLine("Send the email");
        _logProvider.LogInfo("finish to send the message");
    }
}

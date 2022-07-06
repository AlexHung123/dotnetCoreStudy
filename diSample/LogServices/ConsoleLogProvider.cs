namespace LogServices;

public class ConsoleLogProvider : ILogProvider
{
    public void LogError(string message)
    {
        System.Console.WriteLine("Error");
    }

    public void LogInfo(string message)
    {
        System.Console.WriteLine("Info");
    }
}

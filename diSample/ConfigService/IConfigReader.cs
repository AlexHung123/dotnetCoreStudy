namespace ConfigService;

public interface IConfigReader
{
    public string GetValue(string name);
}

namespace ConfigService;

public class EnvVarConfigService:IConfigService
{
    public string GetValue(string key){
        return Environment.GetEnvironmentVariable(key);
    }
}

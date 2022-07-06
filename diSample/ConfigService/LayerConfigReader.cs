namespace ConfigService;

public class LayerConfigReader : IConfigReader
{
    private readonly IEnumerable<IConfigService> _configServices;

    public LayerConfigReader(IEnumerable<IConfigService> config){
        this._configServices = config;
    }
    public string GetValue(string name)
    {
        string value = null;
        foreach (var configService in _configServices){
            string newValue = configService.GetValue(name);
            if(newValue != null){
                value = newValue;
            }
        }
        return value;
    }
}

public class AppSettingsExtractor
{
    public readonly Appsettings AppSettings = new Appsettings();
    public AppSettingsExtractor(IConfiguration config)
    {
        config.Bind(AppSettings);

    }
}
public class Appsettings
{
    public ConnectionStrings ConnectionStrings { get; set; } = new ConnectionStrings();
}


public class ConnectionStrings
{
    public string MapStorage { get; set; } = "";
}
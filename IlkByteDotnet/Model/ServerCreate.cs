using System;
namespace IlkByteDotnet.Model;

public sealed class ServerCreate
{
    public ServerInformation server_info { get; set; }
}

public sealed class ServerInformation
{
    public string ipv4 { get; set; }
    public string ipv6 { get; set; }
    public string name { get; set; }
    public string osapp { get; set; }
    public string password { get; set; }
    public string service { get; set; }
    public string username { get; set; }
}

public sealed class ServerCreateRequest
{
    public string username { get; set; }
    public object? password { get; set; }
    public string name { get; set; }
    public int os_id { get; set; }
    public int app_id { get; set; }
    public int package_id { get; set; }
}
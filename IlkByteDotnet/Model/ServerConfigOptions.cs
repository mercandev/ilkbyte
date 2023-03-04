using System;
namespace IlkByteDotnet.Model;

public sealed class ServerConfigOptions
{
    public List<Application> application { get; set; }
    public List<OperatingSystem> operating_system { get; set; }
    public List<Package> package { get; set; }
}

public sealed class Application
{
    public int code { get; set; }
    public string name { get; set; }
    public string system { get; set; }
}

public sealed class OperatingSystem
{
    public int code { get; set; }
    public string name { get; set; }
    public string version { get; set; }
}

public sealed class Package
{
    public int code { get; set; }
    public string features { get; set; }
    public string name { get; set; }
    public string price { get; set; }
}
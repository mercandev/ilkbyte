using System;
namespace IlkByteDotnet.Model;

public sealed class Server
{
    public Pagination pagination { get; set; }
    public List<ServerList> server_list { get; set; }
}

public sealed class ServerList
{
    public Int64 bandwidth_limit { get; set; }
    public Int64 bandwidth_usage { get; set; }
    public string deleted_time { get; set; }
    public string ipv4 { get; set; }
    public string ipv6 { get; set; }
    public string name { get; set; }
    public string osapp { get; set; }
    public string service { get; set; }
    public string status { get; set; }
}

public sealed class ServerStatus
{
    public string service { get; set; }
    public string status { get; set; }
    public string ipv4 { get; set; }
    public string ipv6 { get; set; }
    public Int64 bandwidth_limit { get; set; }
    public Int64 bandwidth_usage { get; set; }
}

public sealed class ServerPowerManagement
{
    public string status { get; set; }
}

public sealed class ServerIpList
{
    public List<Ipv4> ipv4 { get; set; }
    public List<Ipv6> ipv6 { get; set; }
}

public sealed class Ipv4
{
    public string address { get; set; }
    public string acl_list { get; set; }
    public string usage { get; set; }
    public string rdns { get; set; }
}

public sealed class Ipv6
{
    public string address { get; set; }
    public string acl_list { get; set; }
    public string usage { get; set; }
    public string rdns { get; set; }
}

public sealed class ServerIpLogs
{
    public string ip_prefix { get; set; }
    public bool is_log { get; set; }
    public bool is_person { get; set; }
    public string log_file { get; set; }
    public string rule_in { get; set; }
    public string rule_out { get; set; }
    public string rule_type { get; set; }
}
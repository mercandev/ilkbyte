using System;
namespace IlkByteDotnet.Model;


public sealed class DomainList
{
    public List<DomainListDetail> domain_list { get; set; }
    public Pagination pagination { get; set; }
}


public sealed class DomainListDetail
{
    public string domain { get; set; }
    public NameServer nameserver { get; set; }
}

public sealed class NameServer
{
    public string master { get; set; }
    public string slave { get; set; }
}

public sealed class DomainCreateRequest
{
    public string Domain { get; set; }
    public string Server { get; set; }
    public bool Ipv6 { get; set; }
}
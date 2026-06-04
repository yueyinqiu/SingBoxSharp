namespace SingBoxSharp.Configuration.Dns.DnsServers;

public abstract class SingBoxDnsServer
{
    public string? Type { get; set; }
    public string? Tag { get; set; }
}
namespace SingBoxSharp.Configuration.Dns.DnsServers;

public sealed class SingBoxDnsServerLocal : SingBoxDnsServer
{
    public bool? PreferGo { get; set; }
    public List<string>? NeighborDomain { get; set; }
}
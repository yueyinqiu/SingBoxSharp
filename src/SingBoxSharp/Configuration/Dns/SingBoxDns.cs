using SingBoxLib.Configuration.Dns.Abstract;
using SingBoxSharp.Configuration.Dns.DnsServers;

namespace SingBoxLib.Configuration.Dns;

public sealed class SingBoxDns
{
    public List<SingBoxDnsServer>? Servers { get; set; }
    public List<DnsRuleBase>? Rules { get; set; }
    public string? Final { get; set; }
    public string? Strategy { get; set; }
    public bool? DisableCache { get; set; }
    public bool? DisableExpire { get; set; }
    public bool? IndependentCache { get; set; }
    public int? CacheCapacity { get; set; }
    public bool? ReverseMapping { get; set; }
    public string? ClientSubnet { get; set; }
    public FakeIp? Fakeip { get; set; }
}
public static class DnsStrategy
{
    public const string PreferIpv4 = "prefer_ipv4";
    public const string PreferIpv6 = "prefer_ipv6";
    public const string Ipv4Only = "ipv4_only";
    public const string Ipv6Only = "ipv6_only";
}
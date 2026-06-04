namespace SingBoxSharp.Configuration.Dns.DnsServers;

public abstract class SingBoxDnsServerWithDialFields
{
    public string? Detour { get; set; }
    public string? BindInterface { get; set; }
    public string? Inet4BindAddress { get; set; }
    public string? Inet6BindAddress { get; set; }
    public int? RoutingMark { get; set; }
    public bool? ReuseAddr { get; set; }
    public string? Netns { get; set; }
    public string? ConnectTimeout { get; set; }
    public bool? TcpFastOpen { get; set; }
    public bool? TcpMultiPath { get; set; }
    public bool? DisableTcpKeepAlive { get; set; }
    public string? TcpKeepAlive { get; set; }
    public string? TcpKeepAliveInterval { get; set; }
    public bool? UdpFragment { get; set; }
    public ??? DomainResolver { get; set; }


    /// <summary>
    /// Domain strategy. Available values: prefer_ipv4, prefer_ipv6, ipv4_only, ipv6_only.
    /// If set, the requested domain name will be resolved to IP before connect.
    /// </summary>
    [JsonProperty("domain_strategy")]
    public string? DomainStrategy { get; set; }

    /// <summary>
    /// Network types to use when using default or hybrid network strategy or preferred network types to
    /// use when using fallback network strategy. Available values: wifi, cellular, ethernet, other.
    /// Device's default network is used by default.
    /// </summary>
    [JsonProperty("network_type")]
    public string[]? NetworkType { get; set; }

    /// <summary>
    /// Fallback network types when preferred networks are unavailable or timeout when using fallback
    /// network strategy. All other networks expect preferred are used by default.
    /// </summary>
    [JsonProperty("fallback_network_type")]
    public string[]? FallbackNetworkType { get; set; }

    /// <summary>
    /// The length of time to wait before spawning a RFC 6555 Fast Fallback connection. For domain_strategy, is
    /// the amount of time to wait for connection to succeed before assuming that IPv4/IPv6 is misconfigured and
    /// falling back to other type of addresses. For network_strategy, is the amount of time to wait for
    /// connection to succeed before falling back to other interfaces. Only take effect when domain_strategy or
    /// network_strategy is set. 300ms is used by default.
    /// </summary>
    [JsonProperty("fallback_delay")]
    public string? FallbackDelay { get; set; }
}
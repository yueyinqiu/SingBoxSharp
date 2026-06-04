using SingboxLib.Configuration.Endpoint.Abstract;
using SingBoxLib.Configuration.Certificate;
using SingBoxLib.Configuration.CertificateProvider;
using SingBoxLib.Configuration.CertificateProviders;
using SingBoxLib.Configuration.Dns;
using SingBoxLib.Configuration.Experimental;
using SingBoxLib.Configuration.HttpClient;
using SingBoxLib.Configuration.HttpClients;
using SingBoxLib.Configuration.Inbound.Abstract;
using SingBoxLib.Configuration.Log;
using SingBoxLib.Configuration.Ntp;
using SingBoxLib.Configuration.Outbound.Abstract;
using SingBoxLib.Configuration.Route;
using SingBoxLib.Configuration.Service;

namespace SingBoxLib.Configuration;

public sealed class SingBoxConfiguration
{
    public SingBoxLog? Log { get; set; }
    public SingBoxDns? Dns { get; set; }
    public NtpConfig? Ntp { get; set; }

    public SingBoxCertificate? Certificate { get; set; }
    public List<SingBoxCertificateProvider>? CertificateProviders { get; set; }
    public List<SingBoxHttpClient>? HttpClients { get; set; }

    public List<EndpointConfig>? Endpoints { get; set; }
    public List<InboundConfig>? Inbounds { get; set; }
    public List<OutboundConfig>? Outbounds { get; set; }
    public RouteConfig? Route { get; set; }

    public List<SingBoxService>? Services { get; set; }
    public ExperimentalConfig? Experimental { get; set; }
}
using SingBoxSharp.Configuration.Certificate;
using SingBoxSharp.Configuration.CertificateProvider;
using SingBoxSharp.Configuration.Dns;
using SingBoxSharp.Configuration.Endpoint;
using SingBoxSharp.Configuration.Experimental;
using SingBoxSharp.Configuration.HttpClient;
using SingBoxSharp.Configuration.Inbound;
using SingBoxSharp.Configuration.Log;
using SingBoxSharp.Configuration.Ntp;
using SingBoxSharp.Configuration.Outbound;
using SingBoxSharp.Configuration.Route;
using SingBoxSharp.Configuration.Service;

namespace SingBoxSharp.Configuration;

public sealed class SingBoxConfiguration
{
    public SingBoxLog? Log { get; set; }
    public SingBoxDns? Dns { get; set; }
    public SingBoxNtp? Ntp { get; set; }

    public SingBoxCertificate? Certificate { get; set; }
    public List<SingBoxCertificateProvider>? CertificateProviders { get; set; }
    public List<SingBoxHttpClient>? HttpClients { get; set; }

    public List<SingBoxEndpoint>? Endpoints { get; set; }
    public List<SingBoxInbound>? Inbounds { get; set; }
    public List<SingBoxOutbound>? Outbounds { get; set; }
    public SingBoxRoute? Route { get; set; }

    public List<SingBoxService>? Services { get; set; }
    public SingBoxExperimental? Experimental { get; set; }
}

using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

using STIL.ServiceClient.DTOs.SPSA;
using STIL.ServiceClient.DTOs.SPSA.GetOrdrer;
using STIL.ServiceClient.DTOs.SPSA.Ping;
using STIL.ServiceClient.DTOs.SPSA.UpdateOrdreStatus;

namespace STIL.ServiceClient;

public class StilSPSAServiceClient
{
    private const string BaseUrl = "https://integrationsplatformen.dk/services/SPSA/OrdreService/v1.0";

    private readonly Uri _baseUrl;
    private readonly X509Certificate2 _signingCertificate;
    private readonly ISoapServiceClient _soapServiceClient;

    public StilSPSAServiceClient(X509Certificate2 signingCertificate, HttpClient httpClient)
        : this(BaseUrl, signingCertificate, new SoapServiceClient(httpClient))
    {
    }

    public StilSPSAServiceClient(X509Certificate2 signingCertificate, ISoapServiceClient soapServiceClient)
        : this(BaseUrl, signingCertificate, soapServiceClient)
    {
    }

    public StilSPSAServiceClient(string baseUrl, X509Certificate2 signingCertificate, HttpClient httpClient)
        : this(baseUrl, signingCertificate, new SoapServiceClient(httpClient))
    {
    }

    public StilSPSAServiceClient(string baseUrl, X509Certificate2 signingCertificate, ISoapServiceClient soapServiceClient)
    {
        _baseUrl = new Uri(baseUrl);
        _signingCertificate = signingCertificate;
        _soapServiceClient = soapServiceClient;
    }

    public async Task Ping()
    {
        // action Ping
        BasicSoapRequestGenerator requestGenerator = new();

        await _soapServiceClient.SendSoapRequest<PingResponse, ServiceFaultDetailer>(_baseUrl, requestGenerator.GetSignedRequest(new Ping(), _signingCertificate));
    }

    public async Task<GetOrdrerResponse> GetOrdrer(GetOrdrerRequest request)
    {
        // action GetOrdrer
        BasicSoapRequestGenerator requestGenerator = new();

        return await _soapServiceClient.SendSoapRequest<GetOrdrerResponse, ServiceFaultDetailer>(_baseUrl, requestGenerator.GetSignedRequest(request, _signingCertificate));
    }

    public async Task<UpdateOrdreStatusesResponse> UpdateOrdreStatuses(UpdateOrdreStatusesRequest request)
    {
        // action UpdateOrdreStatuses
        BasicSoapRequestGenerator requestGenerator = new();

        return await _soapServiceClient.SendSoapRequest<UpdateOrdreStatusesResponse, ServiceFaultDetailer>(_baseUrl, requestGenerator.GetSignedRequest(request, _signingCertificate));
    }
}

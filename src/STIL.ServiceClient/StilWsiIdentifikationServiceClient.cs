using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

using STIL.ServiceClient.DTOs.BPI.Common;
using STIL.ServiceClient.DTOs.BPI.WsiIdentifikation;

namespace STIL.ServiceClient;

public class StilWsiIdentifikationServiceClient : BaseStilBpiServiceClient
{
    private const string BaseUrl = "https://brugerdatabasen.stil.dk/bpi/wsiidentifikation/6";

    public StilWsiIdentifikationServiceClient(string systemId, X509Certificate2 signingCertificate, HttpClient httpClient)
        : base(BaseUrl, systemId, signingCertificate, new SoapServiceClient(httpClient))
    {
    }

    public StilWsiIdentifikationServiceClient(string systemId, X509Certificate2 signingCertificate, ISoapServiceClient soapServiceClient)
        : base(BaseUrl, systemId, signingCertificate, soapServiceClient)
    {
    }

    public StilWsiIdentifikationServiceClient(string baseUrl, string systemId, X509Certificate2 signingCertificate, HttpClient httpClient)
        : base(baseUrl, systemId, signingCertificate, new SoapServiceClient(httpClient))
    {
    }

    public StilWsiIdentifikationServiceClient(string baseUrl, string systemId, X509Certificate2 signingCertificate, ISoapServiceClient soapServiceClient)
        : base(baseUrl, systemId, signingCertificate, soapServiceClient)
    {
    }

    public async Task<string> HentBrugeridFraCpr(string cpr, Guid? messageId = null)
    {
        hentBrugeridFraCpr request = new()
        {
            cpr = cpr,
        };

        hentBrugeridResponse response = await _soapServiceClient.SendSoapRequest<hentBrugeridResponse, AuthentificationError>(
            _baseUrl,
            _requestGenerator.GetSignedRequest(request, _signingCertificate, messageId));

        return response.brugerid;
    }

    public async Task<string> HentCprFraBrugerid(string brugerId, Guid? messageId = null)
    {
        hentCprFraBrugerid request = new()
        {
            brugerid = brugerId,
        };

        hentCprResponse response = await _soapServiceClient.SendSoapRequest<hentCprResponse, AuthentificationError>(
            _baseUrl,
            _requestGenerator.GetSignedRequest(request, _signingCertificate, messageId));

        return response.cpr;
    }
}

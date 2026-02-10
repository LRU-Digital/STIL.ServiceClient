using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

using STIL.ServiceClient.DTOs.BPI.Common;
using STIL.ServiceClient.DTOs.BPI.WsiBruger;

namespace STIL.ServiceClient;

public class StilWsiBrugerServiceClient : BaseStilBpiServiceClient
{
    private const string BaseUrl = "https://brugerdatabasen.stil.dk/bpi/wsibruger/7";

    public StilWsiBrugerServiceClient(string systemId, X509Certificate2 signingCertificate, HttpClient httpClient)
        : base(BaseUrl, systemId, signingCertificate, new SoapServiceClient(httpClient))
    {
    }

    public StilWsiBrugerServiceClient(string systemId, X509Certificate2 signingCertificate, ISoapServiceClient soapServiceClient)
        : base(BaseUrl, systemId, signingCertificate, soapServiceClient)
    {
    }

    public StilWsiBrugerServiceClient(string baseUrl, string systemId, X509Certificate2 signingCertificate, HttpClient httpClient)
        : base(baseUrl, systemId, signingCertificate, new SoapServiceClient(httpClient))
    {
    }

    public StilWsiBrugerServiceClient(string baseUrl, string systemId, X509Certificate2 signingCertificate, ISoapServiceClient soapServiceClient)
        : base(baseUrl, systemId, signingCertificate, soapServiceClient)
    {
    }

    public async Task<hentBrugersInstitutionstilknytningerResponse> HentBrugersInstitutionstilknytninger(string brugerId, Guid? messageId = null)
    {
        hentBrugersInstitutionstilknytninger request = new()
        {
            brugerid = brugerId,
        };

        hentBrugersInstitutionstilknytningerResponse response = await _soapServiceClient.SendSoapRequest<hentBrugersInstitutionstilknytningerResponse, AuthentificationError>(
            _baseUrl,
            _requestGenerator.GetSignedRequest(request, _signingCertificate, messageId));

        return response;
    }
}

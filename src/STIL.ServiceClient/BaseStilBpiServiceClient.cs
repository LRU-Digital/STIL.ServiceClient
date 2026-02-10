using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using STIL.ServiceClient.DTOs.BPI.Common;

namespace STIL.ServiceClient;

public abstract class BaseStilBpiServiceClient
{
    protected readonly Uri _baseUrl;
    protected readonly X509Certificate2 _signingCertificate;
    protected readonly ISoapServiceClient _soapServiceClient;
    protected readonly BpiSoapRequestGenerator _requestGenerator;

    protected BaseStilBpiServiceClient(string baseUrl, string systemId, X509Certificate2 signingCertificate, ISoapServiceClient soapServiceClient)
    {
        _baseUrl = new Uri(baseUrl);
        _signingCertificate = signingCertificate;
        _soapServiceClient = soapServiceClient;
        _requestGenerator = new BpiSoapRequestGenerator(baseUrl, systemId);
    }

    public async Task Ping(Guid? messageId = null)
    {
        helloWorldWithCertificateResponse response = await _soapServiceClient.SendSoapRequest<helloWorldWithCertificateResponse, AuthentificationError>(
            _baseUrl,
            _requestGenerator.GetSignedRequest(new helloWorldWithCertificate(), _signingCertificate, messageId));
    }

    public async Task<hentDataAftalerResponse> hentDataAftaler(Guid? messageId = null)
    {
        hentDataAftalerResponse response = await _soapServiceClient.SendSoapRequest<hentDataAftalerResponse, AuthentificationError>(
            _baseUrl,
            _requestGenerator.GetSignedRequest(new hentDataAftaler(), _signingCertificate, messageId));

        return response;
    }
}

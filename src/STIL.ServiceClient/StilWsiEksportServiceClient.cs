using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

using STIL.ServiceClient.DTOs.BPI.Common;
using STIL.ServiceClient.DTOs.BPI.WsiEksport.Medium;
using STIL.ServiceClient.DTOs.BPI.WsiEksport.Small;

namespace STIL.ServiceClient;

public class StilWsiEksportServiceClient : BaseStilBpiServiceClient
{
    private const string BaseUrl = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7";

    public StilWsiEksportServiceClient(string systemId, X509Certificate2 signingCertificate, HttpClient httpClient)
        : base(BaseUrl, systemId, signingCertificate, new SoapServiceClient(httpClient))
    {
    }

    public StilWsiEksportServiceClient(string systemId, X509Certificate2 signingCertificate, ISoapServiceClient soapServiceClient)
        : base(BaseUrl, systemId, signingCertificate, soapServiceClient)
    {
    }

    public StilWsiEksportServiceClient(string baseUrl, string systemId, X509Certificate2 signingCertificate, HttpClient httpClient)
        : base(baseUrl, systemId, signingCertificate, new SoapServiceClient(httpClient))
    {
    }

    public StilWsiEksportServiceClient(string baseUrl, string systemId, X509Certificate2 signingCertificate, ISoapServiceClient soapServiceClient)
        : base(baseUrl, systemId, signingCertificate, soapServiceClient)
    {
    }

    public async Task<EksporterXmlLilleResponse> EksporterXmlLille(string instnr, Guid? messageId = null)
    {
        EksporterXmlLilleResponse response = await _soapServiceClient.SendSoapRequest<EksporterXmlLilleResponse, AuthentificationError>(
            _baseUrl,
            _requestGenerator.GetSignedRequest(new eksporterXmlLille { instnr = instnr }, _signingCertificate, messageId));

        return response;
    }

    public async Task<EksporterXmlMellemResponse> EksporterXmlMedium(string instnr, Guid? messageId = null)
    {
        EksporterXmlMellemResponse response = await _soapServiceClient.SendSoapRequest<EksporterXmlMellemResponse, AuthentificationError>(
            _baseUrl,
            _requestGenerator.GetSignedRequest(new eksporterXmlMellem { instnr = instnr }, _signingCertificate, messageId));

        return response;
    }

    public async Task<HentDataAftalerLilleResponse> HentDataAftalerLille(Guid? messageId = null)
    {
        HentDataAftalerLilleResponse response = await _soapServiceClient.SendSoapRequest<HentDataAftalerLilleResponse, AuthentificationError>(
            _baseUrl,
            _requestGenerator.GetSignedRequest(new hentDataAftalerLille(), "hentDataAftalerLille", _signingCertificate, messageId));

        return response;
    }

    public async Task<HentDataAftalerMellemResponse> HentDataAftalerMellem(Guid? messageId = null)
    {
        HentDataAftalerMellemResponse response = await _soapServiceClient.SendSoapRequest<HentDataAftalerMellemResponse, AuthentificationError>(
            _baseUrl,
            _requestGenerator.GetSignedRequest(new hentDataAftalerMellem(), "hentDataAftalerMellem", _signingCertificate, messageId));

        return response;
    }
}
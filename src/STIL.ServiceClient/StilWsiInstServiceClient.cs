using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

using STIL.ServiceClient.DTOs.BPI.Common;
using STIL.ServiceClient.DTOs.BPI.WsiInst;

namespace STIL.ServiceClient;

public class StilWsiInstServiceClient : BaseStilBpiServiceClient
{
    private const string BaseUrl = "https://brugerdatabasen.stil.dk/bpi/wsiinst/6";

    public StilWsiInstServiceClient(string systemId, X509Certificate2 signingCertificate, HttpClient httpClient)
        : base(BaseUrl, systemId, signingCertificate, new SoapServiceClient(httpClient))
    {
    }

    public StilWsiInstServiceClient(string systemId, X509Certificate2 signingCertificate, ISoapServiceClient soapServiceClient)
        : base(BaseUrl, systemId, signingCertificate, soapServiceClient)
    {
    }

    public StilWsiInstServiceClient(string baseUrl, string systemId, X509Certificate2 signingCertificate, HttpClient httpClient)
        : base(baseUrl, systemId, signingCertificate, new SoapServiceClient(httpClient))
    {
    }

    public StilWsiInstServiceClient(string baseUrl, string systemId, X509Certificate2 signingCertificate, ISoapServiceClient soapServiceClient)
        : base(baseUrl, systemId, signingCertificate, soapServiceClient)
    {
    }

    public async Task<hentGrupperResponse> HentGrupper(string instnr, Guid? messageId = null)
    {
        hentGrupperResponse response = await _soapServiceClient.SendSoapRequest<hentGrupperResponse, AuthentificationError>(
            _baseUrl,
            _requestGenerator.GetSignedRequest(new hentGrupper { instnr = instnr}, _signingCertificate, messageId));

        return response;
    }

    public async Task<hentBrugereIGruppeResponse> HentBrugereIGruppe(string instnr, string gruppeId, Guid? messageId = null)
    {
        hentBrugereIGruppe request = new()
        {
            instnr = instnr,
            gruppeid = gruppeId,
        };

        hentBrugereIGruppeResponse response = await _soapServiceClient.SendSoapRequest<hentBrugereIGruppeResponse, AuthentificationError>(
            _baseUrl,
            _requestGenerator.GetSignedRequest(request, _signingCertificate, messageId));

        return response;
    }

    public async Task<hentInstitutionResponse> HentInstitution(string instnr, Guid? messageId = null)
    {
        hentInstitution request = new()
        {
            instnr = instnr,
        };

        hentInstitutionResponse response = await _soapServiceClient.SendSoapRequest<hentInstitutionResponse, AuthentificationError>(
            _baseUrl,
            _requestGenerator.GetSignedRequest(request, _signingCertificate, messageId));

        return response;
    }

    public async Task<hentInstitutionerResponse> HentInstitutioner(string[] instnr, Guid? messageId = null)
    {
        hentInstitutionerRequest request = new()
        {
            hentInstitutioner = instnr,
        };

        hentInstitutionerResponse response = await _soapServiceClient.SendSoapRequest<hentInstitutionerResponse, AuthentificationError>(
            _baseUrl,
            _requestGenerator.GetSignedRequest(request, "hentInstitutioner", _signingCertificate, messageId));

        return response;
    }

    public async Task<hentInstBrugerResponse> HentInstBruger(string instnr, string brugerId, Guid? messageId = null)
    {
        hentInstBruger request = new()
        {
            instnr = instnr,
            brugerid = brugerId,
        };

        hentInstBrugerResponse response = await _soapServiceClient.SendSoapRequest<hentInstBrugerResponse, AuthentificationError>(
            _baseUrl,
            _requestGenerator.GetSignedRequest(request, _signingCertificate, messageId));

        return response;
    }

    public async Task<HentInstitutionshierarkiResponse> HentInstitutionshierarki(string instnr, Guid? messageId = null)
    {
        hentInstitutionshierarki request = new()
        {
            instnr = instnr,
        };

        HentInstitutionshierarkiResponse response = await _soapServiceClient.SendSoapRequest<HentInstitutionshierarkiResponse, AuthentificationError>(
            _baseUrl,
            _requestGenerator.GetSignedRequest(request, _signingCertificate, messageId));

        return response;
    }
}

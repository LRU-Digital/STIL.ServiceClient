using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml.Linq;

using STIL.ServiceClient.Util.SoapHelper;

namespace STIL.ServiceClient;

public class BpiSoapRequestGenerator
{
    private readonly string _serviceUrl;
    private readonly string _systemId;

    public BpiSoapRequestGenerator(string serviceUrl, string systemId)
    {
        _serviceUrl = serviceUrl;
        _systemId = systemId;
    }

    public string GetSignedRequest<TRequest>(TRequest requestObject,
                                             string action,
                                             X509Certificate2 signingCertificate,
                                             Guid? messageId = null)
    {
        Guid requestId = messageId ?? Guid.NewGuid();
        
        SoapRequestBuilder<TRequest> builder2 = new(requestId);

        XDocument requestDoc2 = builder2.AddBody(requestObject)
            .AddBinarySecurityToken(signingCertificate)
            .AddTimeStamp()
            .AddWSAActionAndMessageId($"{_serviceUrl}/{action}")
            .AddBPISystemId(_systemId)
            .Build();

        SoapMessageSigner signer = new(requestDoc2);
        string requestXml = signer
            .AddReference("Timestamp", requestId)
            .AddReference("Body", requestId)
            .AddReference("Action", requestId)
            .AddReference("MessageId", requestId)
            .AddReference("UdbydersystemId", requestId)
            .Sign(requestId, signingCertificate, SignedXml.XmlDsigRSASHA256Url);

        return requestXml;
    }

    public string GetSignedRequest<TRequest>(TRequest requestObject,
                                             X509Certificate2 signingCertificate,
                                             Guid? messageId = null)
    {
        return GetSignedRequest(requestObject, requestObject.GetType().Name, signingCertificate, messageId);
    }
}

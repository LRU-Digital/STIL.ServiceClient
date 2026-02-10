using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml.Linq;
using STIL.ServiceClient.Util.SoapHelper;

namespace STIL.ServiceClient;

public class BasicSoapRequestGenerator
{
    public string GetSignedRequest<TRequest>(TRequest requestObject, X509Certificate2 signingCertificate, Guid? messageId = null)
    {
        SoapRequestBuilder<TRequest> builder = new(messageId ?? Guid.NewGuid());

        XDocument requestDoc = builder.AddBody(requestObject)
                                      .AddBinarySecurityToken(signingCertificate)
                                      .AddTimeStamp()
                                      .Build();

        return new SoapMessageSigner(requestDoc)
            .AddReference("Body", builder.RequestId)
            .AddReference("Timestamp", builder.RequestId)
            .Sign(builder.RequestId, signingCertificate, SignedXml.XmlDsigRSASHA1Url);
    }
}

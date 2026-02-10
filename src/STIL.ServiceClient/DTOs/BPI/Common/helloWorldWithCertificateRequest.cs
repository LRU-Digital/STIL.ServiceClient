using System.ServiceModel;
using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.Common;

public class helloWorldWithCertificateRequest
{
    [MessageBodyMember(Namespace="https://brugerdatabasen.stil.dk/bpi/common/3", Order=0)]
    public NoArgs helloWorldWithCertificate { get; set; }
}
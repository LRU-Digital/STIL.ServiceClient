using System.ServiceModel;

using STIL.ServiceClient.DTOs.BPI.Common;

namespace STIL.ServiceClient.DTOs.BPI.WsiBruger;

public class hentBrugersInstitutionstilknytningerRequest
{
    [MessageHeader(Namespace="https://brugerdatabasen.stil.dk/bpi/common/3")]
    public UdbydersystemIdType UdbydersystemId { get; set; }

    [MessageBodyMember(Namespace="https://brugerdatabasen.stil.dk/bpi/wsibruger/7", Order=0)]
    public hentBrugersInstitutionstilknytninger hentBrugersInstitutionstilknytninger { get; set; }
}
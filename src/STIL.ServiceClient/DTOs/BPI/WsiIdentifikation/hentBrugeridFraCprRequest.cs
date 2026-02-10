using System.ServiceModel;

using STIL.ServiceClient.DTOs.BPI.Common;

namespace STIL.ServiceClient.DTOs.BPI.WsiIdentifikation;

public class hentBrugeridFraCprRequest
{
    [MessageHeader(Namespace="https://brugerdatabasen.stil.dk/bpi/common/3")]
    public UdbydersystemIdType UdbydersystemId { get; set; }

    [MessageBodyMember(Namespace="https://brugerdatabasen.stil.dk/bpi/wsiidentifikation/6", Order=0)]
    public hentBrugeridFraCpr hentBrugeridFraCpr { get; set; }
}

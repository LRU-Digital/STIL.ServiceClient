using System.ServiceModel;

using STIL.ServiceClient.DTOs.BPI.Common;

namespace STIL.ServiceClient.DTOs.BPI.WsiInst;

public class hentInstitutionshierarkiRequest
{
    [MessageHeader(Namespace="https://brugerdatabasen.stil.dk/bpi/common/3")]
    public UdbydersystemIdType UdbydersystemId { get; set; }

    [MessageBodyMember(Namespace="https://brugerdatabasen.stil.dk/bpi/wsiinst/6", Order=0)]
    public hentInstitutionshierarki hentInstitutionshierarki { get; set; }
}
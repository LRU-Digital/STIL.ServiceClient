using System.ServiceModel;
using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiInst;

public class hentInstitutionerRequest
{
    [MessageBodyMember(Namespace="https://brugerdatabasen.stil.dk/bpi/wsiinst/6", Order=0)]
    [XmlArrayItem("instnr", IsNullable=false)]
    public string[] hentInstitutioner { get; set; }
}

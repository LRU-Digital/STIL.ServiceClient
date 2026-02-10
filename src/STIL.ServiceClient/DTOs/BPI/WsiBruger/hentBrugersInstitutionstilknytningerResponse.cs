using System.ServiceModel;
using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiBruger;

[MessageContract(IsWrapped=false)]
[XmlType(Namespace="https://brugerdatabasen.stil.dk/bpi/wsibruger/7")]
[XmlRoot(ElementName="hentBrugersInstitutionstilknytningerResponse")]
public class hentBrugersInstitutionstilknytningerResponse
{
    [XmlElement("institutionstilknytning", IsNullable=false)]
    public Institutionstilknytning[] institutionstilknytning { get; set; }
}

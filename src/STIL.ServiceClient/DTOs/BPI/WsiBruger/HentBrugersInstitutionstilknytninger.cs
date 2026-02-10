using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiBruger;

[XmlType(Namespace="https://brugerdatabasen.stil.dk/bpi/wsibruger/7")]
public class hentBrugersInstitutionstilknytninger
{
    [XmlElement(Order=0)]
    public string brugerid { get; set; }
}
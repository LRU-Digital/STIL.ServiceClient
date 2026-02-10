using System.Xml.Serialization;

using STIL.ServiceClient.DTOs.BPI.Common;

namespace STIL.ServiceClient.DTOs.BPI.WsiBruger;

[XmlType(Namespace="https://brugerdatabasen.stil.dk/bpi/wsibruger/7")]
public class InstitutionstilknytningElev
{
    [XmlElement(Order=0)]
    public Elevrolle rolle { get; set; }
}
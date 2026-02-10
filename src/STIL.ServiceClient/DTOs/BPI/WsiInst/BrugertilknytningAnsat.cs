using System.Xml.Serialization;

using STIL.ServiceClient.DTOs.BPI.Common;

namespace STIL.ServiceClient.DTOs.BPI.WsiInst;

[XmlType(Namespace="https://brugerdatabasen.stil.dk/bpi/wsiinst/6")]
public class BrugertilknytningAnsat
{
    [XmlElement("rolle", Order=0)]
    public Ansatrolle[] rolle { get; set; }
}
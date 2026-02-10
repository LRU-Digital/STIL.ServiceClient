using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiInst;

[XmlType(Namespace="https://brugerdatabasen.stil.dk/bpi/wsiinst/6")]
public class hentBrugereIGruppe
{
    [XmlElement(Order=0)]
    public string instnr { get; set; }

    [XmlElement(Order=1)]
    public string gruppeid { get; set; }
}
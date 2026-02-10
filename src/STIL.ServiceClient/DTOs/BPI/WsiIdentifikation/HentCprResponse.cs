using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiIdentifikation;

public class hentCprResponse
{
    [XmlElement(Order=0)]
    public string cpr { get; set; }
}

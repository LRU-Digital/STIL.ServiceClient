using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Medium
{
    [XmlRoot(ElementName = "eksporterXmlMellemResponse", Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7")]
    public class EksporterXmlMellemResponse
    {
        [XmlElement(ElementName = "xml")]
        public EksporterXmlMellemResponseXml xml { get; set; }
    }
}

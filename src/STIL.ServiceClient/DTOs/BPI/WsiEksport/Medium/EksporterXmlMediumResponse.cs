using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Medium
{
    [XmlRoot(ElementName = "eksporterXmlMediumResponse", Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7")]
    public class EksporterXmlMediumResponse
    {
        [XmlElement(ElementName = "xml")]
        public EksporterXmlMediumResponseXml xml { get; set; }
    }
}

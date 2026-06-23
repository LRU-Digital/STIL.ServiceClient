using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Small
{
    [XmlRoot(ElementName = "eksporterXmlLilleResponse", Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7")]
    public class EksporterXmlLilleResponse
    {
        [XmlElement(ElementName = "xml")]
        public EksporterXmlLilleResponseXml xml { get; set; }
    }
}

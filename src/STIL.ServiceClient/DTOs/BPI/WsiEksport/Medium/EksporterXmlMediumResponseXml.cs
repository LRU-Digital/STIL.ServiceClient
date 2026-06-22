using System.Xml.Serialization;
using STIL.ServiceClient.DTOs.BPI.WsiEksport.Small;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Medium
{
    public class EksporterXmlMediumResponseXml
    {
        [XmlElement(ElementName = "UNILoginExportMedium", Order = 0, Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/medium")]
        public UNILoginExportMedium UNILoginExportMedium { get; set; }
    }
}
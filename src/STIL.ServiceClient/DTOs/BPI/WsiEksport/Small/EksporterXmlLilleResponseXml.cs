using System.Xml.Serialization;
using STIL.ServiceClient.DTOs.BPI.WsiEksport.Small;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Small
{
    public class EksporterXmlLilleResponseXml
    {
        [XmlElement(ElementName = "UNILoginExportSmall", Order = 0, Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/small")]
        public UNILoginExportSmall UNILoginExportSmall { get; set; }
    }
}
using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Medium
{
    public class EksporterXmlMellemResponseXml
    {
        [XmlElement(ElementName = "UNILoginExportMedium", Order = 0, Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/medium")]
        public UNILoginExportMedium UNILoginExportMedium { get; set; }
    }
}
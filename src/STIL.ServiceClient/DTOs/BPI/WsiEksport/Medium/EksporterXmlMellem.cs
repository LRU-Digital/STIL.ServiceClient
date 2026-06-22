using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Medium
{
    [XmlType(Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7")]
    public class eksporterXmlMellem
    {
        [XmlElement(Order = 0)]
        public string instnr { get; set; }
    }
}
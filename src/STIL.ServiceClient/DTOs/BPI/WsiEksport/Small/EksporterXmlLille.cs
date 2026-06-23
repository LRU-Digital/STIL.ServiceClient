using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Small
{
    [XmlType(Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7")]
    public class eksporterXmlLille
    {
        [XmlElement(Order = 0)]
        public string instnr { get; set; }
    }
}
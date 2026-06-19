using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Common
{
    [XmlType(Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/common")]
    public class ImportSource
    {
        [XmlAttribute("schoolYear")]
        public string SchoolYear { get; set; }

        [XmlAttribute("source")]
        public string Source { get; set; }

        [XmlAttribute("sourceDateTime")]
        public string SourceDateTime { get; set; }
    }
}
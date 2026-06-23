using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Common
{
    [XmlType(Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/common")]
    public class UniLoginExportBase
    {
        [XmlElement("ImportSource")]
        public ImportSource[] ImportSource { get; set; }

        [XmlAttribute("accessLevel")]
        public string AccessLevel { get; set; }
    }
}
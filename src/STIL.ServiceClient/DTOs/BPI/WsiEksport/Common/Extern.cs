using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Common
{
    [XmlType(Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/common")]
    public class Extern
    {
        [XmlElement("GroupId")]
        public string[] GroupId { get; set; }
    }
}
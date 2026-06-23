using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Common
{
    [XmlType(Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/common")]
    public class Group
    {
        [XmlElement("GroupId")]
        public string GroupId { get; set; }

        [XmlElement("GroupName")]
        public string GroupName { get; set; }

        [XmlElement("GroupType")]
        public string GroupType { get; set; }

        [XmlElement("GroupLevel")]
        public string GroupLevel { get; set; }

        [XmlElement("Line")]
        public string Line { get; set; }
    }
}
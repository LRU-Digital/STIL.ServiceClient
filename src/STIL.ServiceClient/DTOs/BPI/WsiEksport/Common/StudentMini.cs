using System.Xml.Serialization;
using STIL.ServiceClient.DTOs.BPI.Common;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Common
{
    [XmlType(Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/common")]
    public class StudentMini
    {
        [XmlElement("Role")]
        public Elevrolle Role { get; set; }

        [XmlElement("StudentNumber")]
        public string StudentNumber { get; set; }

        [XmlElement("Level")]
        public trin Level { get; set; }

        [XmlElement("GroupId")]
        public string[] GroupId { get; set; }

        [XmlElement("MainGroupId")]
        public string MainGroupId { get; set; }
    }
}
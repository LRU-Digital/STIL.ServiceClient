using System.Xml.Serialization;
using STIL.ServiceClient.DTOs.BPI.Common;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Common
{
    [XmlType(Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/common")]
    public class Employee
    {
        [XmlElement("GroupId")]
        public string[] GroupId { get; set; }

        [XmlElement("Role")]
        public Ansatrolle[] Role { get; set; }
        
        [XmlElement("ShortName")]
        public string ShortName { get; set; }
        
        [XmlElement("Occupation")]
        public string Occupation { get; set; }
        
        [XmlElement("Location")]
        public string Location { get; set; }
    }
}
using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Common
{
    [XmlType(Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/common")]
    public class PersonMini
    {
        [XmlElement("FirstName")]
        public string FirstName { get; set; }

        [XmlElement("FamilyName")]
        public string FamilyName { get; set; }

        [XmlElement("UserId")]
        public string UserId { get; set; }
    }
}
using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Common
{
    [XmlType(Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/common")]
    public class InstitutionWithGroupsBase
    {
        [XmlElement("InstitutionNumber")]
        public string InstitutionNumber { get; set; }

        [XmlElement("InstitutionName")]
        public string InstitutionName { get; set; }

        [XmlElement("Group")]
        public Group[] Group { get; set; }
    }
}
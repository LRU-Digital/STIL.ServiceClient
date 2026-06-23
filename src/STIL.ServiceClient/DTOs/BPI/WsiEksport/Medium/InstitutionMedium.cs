using System.Xml.Serialization;
using STIL.ServiceClient.DTOs.BPI.WsiEksport.Common;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Medium
{
    [XmlType(Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/medium")]
    public class InstitutionMedium : InstitutionWithGroupsBase
    {
        [XmlElement("InstitutionPerson")]
        public InstitutionPersonMedium[] InstitutionPerson { get; set; }
    }
}
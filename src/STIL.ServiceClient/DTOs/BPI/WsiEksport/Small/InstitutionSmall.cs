using System.Xml.Serialization;
using STIL.ServiceClient.DTOs.BPI.WsiEksport.Common;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Small
{
    [XmlType(Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/small")]
    public class InstitutionSmall : InstitutionWithGroupsBase
    {
        [XmlElement("InstitutionPerson")]
        public InstitutionPersonSmall[] InstitutionPerson { get; set; }
    }
}
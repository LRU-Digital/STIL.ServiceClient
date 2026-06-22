using System.Xml.Serialization;
using STIL.ServiceClient.DTOs.BPI.WsiEksport.Common;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Medium
{
 [XmlType(Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/medium")]
    public class InstitutionPersonMedium : InstitutionPersonExportBase
    {
        [XmlElement("Person", Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/medium")]
        public PersonMedium Person { get; set; }

        [XmlElement("Student", typeof(StudentMini), Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/small")]
        [XmlElement("Employee", typeof(Employee), Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/common")]
        [XmlElement("Extern", typeof(Extern), Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/common")]
        public object Item { get; set; }
    }
}
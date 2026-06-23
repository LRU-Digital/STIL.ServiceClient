using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Common
{
    [XmlType(Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/common")]
    public class InstitutionPersonExportBase
    {
        [XmlAttribute("source")]
        public string Source { get; set; }
    }
}
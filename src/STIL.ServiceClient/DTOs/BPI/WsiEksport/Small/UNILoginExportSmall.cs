using System;
using System.Xml.Serialization;
using STIL.ServiceClient.DTOs.BPI.WsiEksport.Common;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Small
{
    [XmlType(Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/small")]
    public class UNILoginExportSmall : UniLoginExportBase
    {
        [XmlElement("Institution")]
        public InstitutionSmall Institution { get; set; }
        [XmlAttribute("exportDateTime")]
        public DateTime ExportDateTime { get; set; }
    }
}
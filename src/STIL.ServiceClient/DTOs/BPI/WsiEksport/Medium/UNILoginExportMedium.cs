using System;
using System.Xml.Serialization;
using STIL.ServiceClient.DTOs.BPI.WsiEksport.Common;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Medium
{
    [XmlType(Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/medium")]
    public class UNILoginExportMedium : UniLoginExportBase
    {
        [XmlElement("Institution")]
        public InstitutionMedium Institution { get; set; }
        [XmlAttribute("exportDateTime")]
        public DateTime ExportDateTime { get; set; }
    }
}
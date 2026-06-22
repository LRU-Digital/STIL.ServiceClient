using System.ServiceModel;
using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Medium
{
    [XmlRoot(ElementName = "hentDataAftalerMellemResponse", Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7")]
    public class HentDataAftalerMellemResponse
    {
        [XmlElement("regnr", Namespace = "https://brugerdatabasen.stil.dk/bpi/common/3")]

        public string[] hentDataAftalerMellemResponse { get; set; }
    }
}
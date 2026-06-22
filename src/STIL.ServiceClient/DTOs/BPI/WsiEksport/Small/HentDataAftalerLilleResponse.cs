using System.ServiceModel;
using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Small
{
    [XmlRoot(ElementName = "hentDataAftalerLilleResponse", Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7")]
    public class HentDataAftalerLilleResponse
    {
        [XmlElement("regnr", Namespace = "https://brugerdatabasen.stil.dk/bpi/common/3")]

        public string[] hentDataAftalerLilleResponse { get; set; }
    }
}
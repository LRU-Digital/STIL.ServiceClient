using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.WsiEksport.Common
{
    [XmlType(Namespace = "https://brugerdatabasen.stil.dk/bpi/wsieksport/7/common")]
    public class PersonMedium : PersonMini
    {
        [XmlElement("CivilRegistrationNumberType")]
        public string CivilRegistrationNumberType { get; set; }

        [XmlElement("EmailAddress")]
        public string EmailAddress { get; set; }

        [XmlElement("BirthDate")]
        public string BirthDate { get; set; }

        [XmlElement("Gender")]
        public string Gender { get; set; }

        [XmlElement("PhotoId")]
        public string PhotoId { get; set; }
    }
}
using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.Common;

[XmlType(Namespace="https://brugerdatabasen.stil.dk/bpi/common/3")]
public enum Ansatrolle
{
    Lærer,
    Pædagog,
    Vikar,
    Leder,
    Ledelse,
    TAP,
    Konsulent,
}

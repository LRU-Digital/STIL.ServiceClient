using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.BPI.Common;

[XmlType(Namespace="https://brugerdatabasen.stil.dk/bpi/common/3")]
public class UdbydersystemIdType
{
    [XmlText(DataType="token")]
    public string Value { get; set; }
}

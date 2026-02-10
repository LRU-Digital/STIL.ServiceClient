using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using STIL.ServiceClient.DTOs.BPI.Common;
using STIL.ServiceClient.DTOs.BPI.WsiBruger;
using Xunit;

namespace STIL.ServiceClient.Tests.BPI;

public class DeserialiseTests
{
    [Fact]
    public void HentBrugersInstitutionstilknytningerResponseDeserialise()
    {
        string path = "Samples/HentBrugersInstitutionstilknytningerResponse_ValidResponse.xml";
        XDocument document = XDocument.Load(File.OpenRead(path));
        XElement body = document.Root?.Descendants().FirstOrDefault(d => d.Name.LocalName == nameof(hentBrugersInstitutionstilknytningerResponse));
        
        Assert.NotNull(body);

        string nameSpace = body.Name.NamespaceName;
        XmlSerializer serializer = new XmlSerializer(
            typeof(hentBrugersInstitutionstilknytningerResponse), nameSpace);

        hentBrugersInstitutionstilknytningerResponse response;
        using (XmlReader reader = body.CreateReader())
        {
            reader.MoveToContent();
            response = serializer.Deserialize(reader) as hentBrugersInstitutionstilknytningerResponse;
        }
        
        Assert.NotNull(response?.institutionstilknytning);
    }

    [Fact]
    public void HentBrugersInstitutionstilknytningerResponseSerialise()
    {
        hentBrugersInstitutionstilknytningerResponse response = new()
        {
            institutionstilknytning = 
            [
                new Institutionstilknytning()
                {
                    instnr = "A12249",
                    Item = new InstitutionstilknytningAnsat
                    {
                        rolle = [Ansatrolle.Lærer]
                    }
                },
            ],
        };

        string xml = XmlSerializer<hentBrugersInstitutionstilknytningerResponse>.Serialize(response);
        
        Assert.NotNull(xml);
    }
}

public class XmlSerializer<T> where T : class
{
    public static string Serialize(T obj)
    {
        XmlSerializer xsSubmit = new XmlSerializer(typeof(T));
        using (var sww = new StringWriter())
        {
            using (XmlTextWriter writer = new XmlTextWriter(sww) { Formatting = Formatting.Indented })
            {
                xsSubmit.Serialize(writer, obj);
                return sww.ToString();
            }
        }
    }
}
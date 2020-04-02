using System.Xml.Serialization;

namespace SimpleClicks.Model
{

	[XmlRoot("getClientResponse", Namespace = "http://sequisoft.de/")]
	public class GetClientResponse
	{

		[XmlElement("return", Namespace = "")] public Client? Client { get; set; }

	}

}
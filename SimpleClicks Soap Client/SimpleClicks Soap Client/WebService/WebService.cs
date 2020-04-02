using System.Xml.Serialization;

namespace SimpleClicks.WebService
{

	[XmlType("service", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
	public class WebService
	{

		[XmlAttribute("name")] public string? Name { get; set; }
		[XmlElement("port")] public WebServicePort? Port { get; set; }

		public override string ToString() => Name ?? GetType().ToString();

	}

}
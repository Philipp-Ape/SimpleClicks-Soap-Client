using System.Xml.Serialization;

namespace SimpleClicks.WebService
{

	[XmlType("port", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
	public class WebServicePort
	{

		[XmlAttribute("name")] public string? Name { get; set; }
		[XmlAttribute("binding")] public string? Binding { get; set; }

		[XmlElement("address", Namespace = "http://schemas.xmlsoap.org/wsdl/soap/")]
		public Address? Address { get; set; }

		public override string ToString() => Name ?? GetType().ToString();

	}

}
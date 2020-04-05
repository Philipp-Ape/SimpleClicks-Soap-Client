using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimpleClicks.WebService
{

	// TODO: The definitions should be expanded.

	[XmlRoot("definitions", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
	public class WebServiceDefinition
	{

		[XmlAttribute("targetNamespace")] public string? TargetNamespace { get; set; }
		[XmlElement("service")] public WebService? Service { get; set; }
		[XmlElement("message")] public List<Message>? Messages { get; set; }

		public override string ToString() => TargetNamespace ?? GetType().ToString();

	}

}
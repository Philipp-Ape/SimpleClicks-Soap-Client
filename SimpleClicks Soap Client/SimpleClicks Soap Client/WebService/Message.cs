using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimpleClicks.WebService
{

	[XmlType("message", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
	public class Message
	{

		[XmlAttribute("name")] public string? Name { get; set; }
		[XmlElement("part")] public List<MessagePart>? Parts { get; set; }

		public override string ToString() => Name ?? GetType().ToString();

	}

}
using System.Xml.Serialization;

namespace SimpleClicks.WebService
{

	[XmlType("part", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
	public class MessagePart
	{

		[XmlAttribute("name")] public string? Name { get; set; }
		[XmlAttribute("element")] public string? Element { get; set; }

		public override string ToString() => Name ?? GetType().ToString();

	}

}
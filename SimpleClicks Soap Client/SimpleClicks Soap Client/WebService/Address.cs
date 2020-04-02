using System.Xml.Serialization;

namespace SimpleClicks.WebService
{

	[XmlType("address", Namespace = "http://schemas.xmlsoap.org/wsdl/soap/")]
	public class Address
	{

		[XmlAttribute("location")] public string? Location { get; set; }

		public override string ToString() => Location ?? GetType().ToString();

	}

}
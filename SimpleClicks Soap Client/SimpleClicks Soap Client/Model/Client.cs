using System.Xml.Serialization;

namespace SimpleClicks.Model
{

	public class Client
	{

		[XmlElement("company")] public string? Company { get; set; }

	}

}
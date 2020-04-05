using System;
using System.Xml.Serialization;

namespace SimpleClicks.Model
{

	[Serializable, XmlRoot("getClientResponse", Namespace = "http://sequisoft.de/")]
	public class GetClientResponse
	{

		[XmlElement("return", Namespace = "")] public SimpleClicksClient? Client { get; set; }

		public override string ToString() => Client?.ToString() ?? GetType().ToString();

	}

}
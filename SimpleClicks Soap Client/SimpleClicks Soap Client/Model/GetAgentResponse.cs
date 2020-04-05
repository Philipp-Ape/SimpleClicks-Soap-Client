using System;
using System.Xml.Serialization;

namespace SimpleClicks.Model
{

	[Serializable, XmlRoot("getAgentsResponse", Namespace = "http://sequisoft.de/")]
	public class GetAgentResponse
	{

		[XmlElement("return", Namespace = "")] public Agent? Agent { get; set; }

	}

}
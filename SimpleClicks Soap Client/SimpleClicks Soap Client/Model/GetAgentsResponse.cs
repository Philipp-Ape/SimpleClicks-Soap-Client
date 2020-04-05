using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimpleClicks.Model
{

	[Serializable, XmlRoot("getAgentsResponse", Namespace = "http://sequisoft.de/")]
	public class GetAgentsResponse
	{

		[XmlElement("return", Namespace = "")] public List<Agent>? Agents { get; set; }

	}

}
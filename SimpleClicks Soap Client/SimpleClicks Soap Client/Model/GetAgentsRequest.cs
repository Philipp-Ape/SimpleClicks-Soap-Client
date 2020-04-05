using System;
using System.Xml.Serialization;

namespace SimpleClicks.Model
{

	[Serializable, XmlRoot("getAgents", Namespace = "http://sequisoft.de/")]
	public class GetAgentsRequest { }

}
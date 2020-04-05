using System;
using System.Xml.Serialization;

namespace SimpleClicks.Model
{

	[Serializable, XmlRoot("getAgents", Namespace = "http://sequisoft.de/")]
	public class GetAgentRequest
	{

		[XmlElement("agentId")] public Guid AgentId { get; set; }

		public GetAgentRequest() { }
		public GetAgentRequest(Guid agentId) => AgentId = agentId;

	}

}
using System;
using System.Xml.Serialization;

namespace SimpleClicks.Model
{

	[XmlRoot("getAgentDevices", Namespace = "http://sequisoft.de/")]
	public class GetDevicesRequest
	{

		[XmlElement("agentId")] public Guid? AgentId { get; set; }
		[XmlElement("managed")] public bool Managed { get; set; }

		public GetDevicesRequest() { }

		public GetDevicesRequest(Guid agentId, bool managed = true)
		{
			AgentId = agentId;
			Managed = managed;
		}

	}

}
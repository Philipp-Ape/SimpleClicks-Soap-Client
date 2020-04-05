using System;
using System.Xml.Serialization;

namespace SimpleClicks.Model
{

	[Serializable, XmlRoot("getAgentCounterByDeviceId", Namespace = "http://sequisoft.de/")]
	public class GetCountersRequest
	{

		[XmlElement("agentId")] public Guid AgentId { get; set; }
		[XmlElement("deviceId")] public string? DeviceId { get; set; }

		public GetCountersRequest() { }

		public GetCountersRequest(Guid agentId, string deviceId)
		{
			AgentId = agentId;
			DeviceId = deviceId;
		}

	}

}
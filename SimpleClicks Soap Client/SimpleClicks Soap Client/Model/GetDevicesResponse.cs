using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimpleClicks.Model
{

	[XmlRoot("getAgentDevicesResponse", Namespace = "http://sequisoft.de/")]
	public class GetDevicesResponse
	{

		[XmlElement("return", Namespace = "")] public List<Device>? Devices { get; set; }

	}

}
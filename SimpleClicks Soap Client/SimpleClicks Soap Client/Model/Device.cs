using System.Xml.Serialization;

namespace SimpleClicks.Model
{

	public class Device
	{

		[XmlElement("deviceId")] public string? DeviceId { get; set; }

	}

}
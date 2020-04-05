using System.Xml.Serialization;

namespace SimpleClicks.Model
{

	public class DeviceNotifications
	{

		[XmlElement("doCounterClearing")] public string? DoCounterClearing { get; set; }
		[XmlElement("doCounterNotification")] public string? DoCounterNotification { get; set; }
		[XmlElement("doContingentWarning")] public string? DoContingentWarning { get; set; }
		[XmlElement("doContingentNotification")] public string? DoContingentNotification { get; set; }
		[XmlElement("doContingentClearingNotification")] public string? DoContingentClearingNotification { get; set; }
		[XmlElement("doSuppliesOrdering")] public string? DoSuppliesOrdering { get; set; }
		[XmlElement("doSuppliesOrderedNotification")] public string? DoSuppliesOrderedNotification { get; set; }
		[XmlElement("doSuppliesNotification")] public string? DoSuppliesNotification { get; set; }
		[XmlElement("doSuppliesChangeNotification")] public string? DoSuppliesChangeNotification { get; set; }
		[XmlElement("doTicketNotification")] public string? DoTicketNotification { get; set; }

	}

}
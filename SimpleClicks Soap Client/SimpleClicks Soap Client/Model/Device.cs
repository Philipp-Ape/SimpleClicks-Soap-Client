using System;
using System.Xml.Serialization;

namespace SimpleClicks.Model
{

	public class Device
	{

		[XmlElement("agentId")] public Guid AgentId { get; set; }
		[XmlElement("deviceId")] public string? DeviceId { get; set; }
		[XmlElement("managed")] public bool Managed { get; set; }
		[XmlElement("name")] public string? Name { get; set; }
		[XmlElement("hostName")] public string? HostName { get; set; }
		[XmlElement("ipAddress")] public string? IpAddress { get; set; }
		[XmlElement("macAddress")] public string? MacAddress { get; set; }
		[XmlElement("manufacturer")] public string? Manufacturer { get; set; }
		[XmlElement("model")] public string? Model { get; set; }
		[XmlElement("sysDescription")] public string? SysDescription { get; set; }
		[XmlElement("deviceDescription")] public string? DeviceDescription { get; set; }
		[XmlElement("location")] public string? Location { get; set; }
		[XmlElement("printerName")] public string? PrinterName { get; set; }
		[XmlElement("serialNo")] public string? SerialNo { get; set; }
		[XmlElement("operator")] public string? Operator { get; set; }
		[XmlElement("servicePerson")] public string? ServicePerson { get; set; }
		[XmlElement("serviceId")] public int ServiceId { get; set; }
		[XmlElement("inventoryNo")] public string? InventoryNo { get; set; }
		[XmlElement("costCentre")] public string? CostCentre { get; set; }
		[XmlElement("locationNo")] public string? LocationNo { get; set; }
		[XmlElement("contractType")] public string? ContractType { get; set; }
		[XmlElement("contractNo")] public string? ContractNo { get; set; }
		[XmlElement("firmwareVersion")] public string? FirmwareVersion { get; set; }
		[XmlElement("salesInfo")] public string? SalesInfo { get; set; }
		[XmlElement("administrationInfo")] public string? AdministrationInfo { get; set; }
		[XmlElement("customerInfo")] public string? CustomerInfo { get; set; }
		[XmlElement("serviceInfo")] public string? ServiceInfo { get; set; }
		[XmlElement("deviceAdded")] public string? DeviceAdded { get; set; }
		[XmlElement("lastCounterUpdate")] public string? LastCounterUpdate { get; set; }
		[XmlElement("lastTonerUpdate")] public string? LastTonerUpdate { get; set; }
		[XmlElement("lastTonerLevelUpdate")] public string? LastTonerLevelUpdate { get; set; }
		[XmlElement("lastInputTrayLevelUpdate")] public string? LastInputTrayLevelUpdate { get; set; }
		[XmlElement("lastOutputTrayLevelUpdate")] public string? LastOutputTrayLevelUpdate { get; set; }
		[XmlElement("lastDeviceStatusUpdate")] public string? LastDeviceStatusUpdate { get; set; }
		[XmlElement("lastAlertsUpdate")] public string? LastAlertsUpdate { get; set; }
		[XmlElement("isPrinter")] public bool IsPrinter { get; set; }
		[XmlElement("customerNo")] public string? CustomerNo { get; set; }
		[XmlElement("customerName")] public string? CustomerName { get; set; }
		[XmlElement("customerCity")] public string? CustomerCity { get; set; }
		[XmlElement("deviceNotifications")] public DeviceNotifications? DeviceNotifications { get; set; }
		[XmlElement("contact")] public string? Contact { get; set; }
		[XmlElement("servicePartner")] public string? ServicePartner { get; set; }
		[XmlElement("building")] public string? Building { get; set; }
		[XmlElement("floor")] public string? Floor { get; set; }
		[XmlElement("room")] public string? Room { get; set; }
		[XmlElement("reference1")] public string? Reference1 { get; set; }
		[XmlElement("reference2")] public string? Reference2 { get; set; }
		[XmlElement("reference3")] public string? Reference3 { get; set; }

	}

}
using System;
using System.Xml.Serialization;

namespace SimpleClicks.Model
{

	public class Agent
	{

		[XmlElement("id")] public int  Id { get; set; }
		[XmlElement("agentId")] public Guid AgentId { get; set; }
		[XmlElement("agentName")] public string? AgentName { get; set; }
		[XmlElement("managedDevices")] public int ManagedDevices { get; set; }
		[XmlElement("unmanagedDevices")] public int UnmanagedDevices { get; set; }
		[XmlElement("licenses")] public int Licenses { get; set; }
		[XmlElement("missingLicenses")] public int MissingLicenses { get; set; }
		[XmlElement("agentVersion")] public string? AgentVersion { get; set; }
		[XmlElement("agentBuild")] public int AgentBuild { get; set; }
		[XmlElement("agentDbFixLevel")] public int AgentDbFixLevel { get; set; }
		[XmlElement("agentDbVersion")] public int AgentDbVersion { get; set; }
		[XmlElement("agentOs")] public string? AgentOs { get; set; }
		[XmlElement("agentBrand")] public string? AgentBrand { get; set; }
		[XmlElement("agentBrandName")] public string? AgentBrandName { get; set; }
		[XmlElement("agentIP")] public string? AgentIP { get; set; }
		[XmlElement("agentHostname")] public string? AgentHostname { get; set; }
		[XmlElement("contractNo")] public string? ContractNo { get; set; }
		[XmlElement("alertCount")] public int AlertCount { get; set; }
		[XmlElement("criticalAlertCount")] public int CriticalAlertCount { get; set; }
		[XmlElement("lowSupplies")] public int LowSupplies { get; set; }
		[XmlElement("emptySupplies")] public int EmptySupplies { get; set; }
		[XmlElement("licenseUntil")] public string? LicenseUntil { get; set; }
		[XmlElement("supportUntil")] public string? SupportUntil { get; set; }
		[XmlElement("licenseType")] public string? LicenseType { get; set; }
		[XmlElement("licenseValid")] public bool LicenseValid { get; set; }
		[XmlElement("syncMode")] public string? SyncMode { get; set; }
		[XmlElement("bidiEnabled")] public bool BidiEnabled { get; set; }
		[XmlElement("hasLicense")] public bool HasLicense { get; set; }
		[XmlElement("dbFail")] public bool DbFail { get; set; }
		[XmlElement("syncWarningSend")] public bool SyncWarningSend { get; set; }
		[XmlElement("upSyncTimestamp")] public string? UpSyncTimestamp { get; set; }
		[XmlElement("downSyncTimestamp")] public string? DownSyncTimestamp { get; set; }
		[XmlElement("agentStatus")] public string? AgentStatus { get; set; }
		[XmlElement("customerCity")] public string? CustomerCity { get; set; }
		[XmlElement("customerCompany")] public string? CustomerCompany { get; set; }
		[XmlElement("customerName1")] public string? CustomerName1 { get; set; }
		[XmlElement("customerName2")] public string? CustomerName2 { get; set; }
		[XmlElement("customerNo")] public string? CustomerNo { get; set; }
		[XmlElement("customerPostalCode")] public string? CustomerPostalCode { get; set; }
		[XmlElement("customerStreet")] public string? CustomerStreet { get; set; }
		[XmlElement("syncStatusUp")] public string? SyncStatusUp { get; set; }
		[XmlElement("syncStatusDown")] public string? SyncStatusDown { get; set; }
		[XmlElement("agentBrandDate")] public string? AgentBrandDate { get; set; }
		[XmlElement("supplyContract")] public bool SupplyContract { get; set; }
		[XmlElement("clickContract")] public bool ClickContract { get; set; }
		[XmlElement("recipients")] public int Recipients { get; set; }
		[XmlElement("recipientGroups")] public int RecipientGroups { get; set; }
		[XmlElement("agentInactive")] public bool AgentInactive { get; set; }
		[XmlElement("amqInitialized")] public bool AmqInitialized { get; set; }
		[XmlElement("widgetBooked")] public bool WidgetBooked { get; set; }
		[XmlElement("agentJREVersion")] public string? AgentJREVersion { get; set; }
		[XmlElement("agentSysArch")] public string? AgentSysArch { get; set; }
		[XmlElement("sdsBooked")] public bool SdsBooked { get; set; }
		[XmlElement("sdsDevices")] public int SdsDevices { get; set; }
		[XmlElement("kfsDevices")] public int KfsDevices { get; set; }
		[XmlElement("diskSpace")] public int DiskSpace { get; set; }
		[XmlElement("diskFreeSpace")] public int DiskFreeSpace { get; set; }

	}

}
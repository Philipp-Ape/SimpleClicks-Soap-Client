using System;
using System.Xml.Serialization;

namespace SimpleClicks.Model
{

	[Serializable]
	public class ClientLogin
	{

		[XmlElement("userId")] public string? UserId { get; set; }
		[XmlElement("contactId")] public string? ContactId { get; set; }
		[XmlElement("userLogin")] public string? Username { get; set; }
		[XmlElement("manageAgents")] public bool ManageAgents { get; set; }
		[XmlElement("manageUsers")] public bool ManageUsers { get; set; }
		[XmlElement("manageDevices")] public bool ManageDevices { get; set; }
		[XmlElement("manageConfig")] public bool ManageConfig { get; set; }
		[XmlElement("manageNotifications")] public bool ManageNotifications { get; set; }
		[XmlElement("manageSupplies")] public bool ManageSupplies { get; set; }
		[XmlElement("monitorDevices")] public bool MonitorDevices { get; set; }
		[XmlElement("viewStatistics")] public bool ViewStatistics { get; set; }
		[XmlElement("useServiceModule")] public bool UseServiceModule { get; set; }
		[XmlElement("autoManager")] public bool AutoManager { get; set; }
		[XmlElement("autoMonitor")] public bool AutoMonitor { get; set; }
		[XmlElement("hideElements")] public bool HideElements { get; set; }
		[XmlElement("useSoapService")] public bool UseSoapService { get; set; }
		[XmlElement("writeAccess")] public bool WriteAccess { get; set; }
		[XmlElement("assignedGroups")] public string? AssignedGroups { get; set; }
		[XmlElement("assignedAgents")] public string? AssignedAgents { get; set; }
		[XmlElement("serverMode")] public bool ServerMode { get; set; }
		[XmlElement("isFlat")] public bool IsFlat { get; set; }
		[XmlElement("isLicenseInvalid")] public bool IsLicenseInvalid { get; set; }
		[XmlElement("externalInterfaceEnabled")] public bool ExternalInterfaceEnabled { get; set; }
		[XmlElement("isSupportInvalid")] public bool IsSupportInvalid { get; set; }
		[XmlElement("isSupportOut")] public bool IsSupportOut { get; set; }
		[XmlElement("isLicenseOut")] public bool IsLicenseOut { get; set; }
		[XmlElement("canChangeNetwork")] public bool CanChangeNetwork { get; set; }
		[XmlElement("supportUntil")] public string? SupportUntil { get; set; }
		[XmlElement("licenseUntil")] public string? LicenseUntil { get; set; }
		[XmlElement("loginType")] public int LoginType { get; set; }
		[XmlElement("passwordTarget")] public string? PasswordTarget { get; set; }

		public string[]? GetAssignedGroups()
		{
			if (AssignedGroups == null) return null;
			string[] values = AssignedGroups.TrimStart('[').TrimEnd(']').Split(',', StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < values.Length; i++) values[i] = values[i].Trim('"');
			return values;
		}

		public string[]? GetAssignedAgents()
		{
			if (AssignedAgents == null) return null;
			string[] values = AssignedAgents.TrimStart('[').TrimEnd(']').Split(',', StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < values.Length; i++) values[i] = values[i].Trim('"');
			return values;
		}

		public override string ToString() => Username ?? GetType().ToString();

	}

}
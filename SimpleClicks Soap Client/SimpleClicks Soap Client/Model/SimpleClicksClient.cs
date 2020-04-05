using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimpleClicks.Model
{

	public class SimpleClicksClient
	{

		[XmlElement("contactType")] public int? ContactType { get; set; }
		[XmlElement("contactId")] public string? ContactId { get; set; }
		[XmlElement("contactNo")] public string? ContactNo { get; set; }
		[XmlElement("title")] public string? Title { get; set; }
		[XmlElement("name1")] public string? Name1 { get; set; }
		[XmlElement("name2")] public string? Name2 { get; set; }
		[XmlElement("company")] public string? Company { get; set; }
		[XmlElement("street")] public string? Street { get; set; }
		[XmlElement("postalCode")] public string? PostalCode { get; set; }
		[XmlElement("city")] public string? City { get; set; }
		[XmlElement("country")] public string? Country { get; set; }
		[XmlElement("mail")] public string? Mail { get; set; }
		[XmlElement("phone")] public string? Phone { get; set; }
		[XmlElement("mobile")] public string? Mobile { get; set; }
		[XmlElement("fax")] public string? Fax { get; set; }
		[XmlElement("logins")] public List<ClientLogin>? Logins { get; set; }

		public override string ToString() => Company ?? GetType().ToString();

	}

}
using System;
using System.Xml.Serialization;

namespace SimpleClicks.Model
{

	[Serializable, XmlRoot("getClient", Namespace = "http://sequisoft.de/")]
	public class GetClientRequest { }

}
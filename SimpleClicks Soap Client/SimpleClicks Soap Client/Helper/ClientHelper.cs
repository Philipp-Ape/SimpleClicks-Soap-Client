using System;

namespace SimpleClicks.Helper
{

	public static class ClientHelper
	{

		public const string ServiceEndPointPath = "soap/internal";
		public const string SerivceDescriptionEndPointQuery = "?wsdl";

		public static Uri GetServiceEndPoint(Uri targetUri) =>
			new UriBuilder()
			{
				Scheme = targetUri.Scheme,
				Host = targetUri.Host,
				Port = targetUri.Port,
				Path = ServiceEndPointPath
			}.Uri;

	}

}
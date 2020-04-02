using SimpleClicks.Helper;
using SimpleClicks.WebService;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.Soap.Serialization;

namespace SimpleClicks
{

	public class SimpleClicksSoapClient : IDisposable
	{

		public IWebProxy Proxy
		{
			get => ClientHandler.Proxy;
			set => ClientHandler.Proxy = value;
		}

		public bool Configured { get; private set; }
		public WebServiceDefinition? ServiceDefinition { get; private set; }

		private readonly Uri EmptyUri = new Uri(string.Empty, UriKind.Relative);
		private readonly CookieContainer CookieContainer = new CookieContainer();
		private readonly HttpClientHandler ClientHandler;
		private readonly HttpClient HttpClient;
		private readonly SoapSerializer Serializer = new SoapSerializer();
		private bool DisposedValue;

		public SimpleClicksSoapClient(Uri baseAddress, NetworkCredential credential, IWebProxy? proxy = null)
		{
			ClientHandler = new HttpClientHandler
			{
				Credentials = credential,
				AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
				UseCookies = true,
				CookieContainer = CookieContainer,
				UseProxy = proxy != null,
				Proxy = proxy
			};

			HttpClient = new HttpClient(ClientHandler)
			{
				BaseAddress = ClientHelper.GetServiceEndPoint(baseAddress)
			};
		}

		public async Task<SimpleClicksSoapClient> Configure()
		{
			Task<WebServiceDefinition> requestTask = GetServiceDescription();
			Configured = true;
			ServiceDefinition = await requestTask;

			Serializer.TargetNamespace = ServiceDefinition?.TargetNamespace ??
				throw new MissingMemberException(nameof(ServiceDefinition.TargetNamespace));

			return this;
		}

		private async Task<WebServiceDefinition> GetServiceDescription()
		{
			using HttpResponseMessage response = await HttpClient.GetAsync(new Uri(ClientHelper.SerivceDescriptionEndPointQuery, UriKind.Relative));
			using Stream stream = await response.EnsureSuccessStatusCode().Content.ReadAsStreamAsync();
			return (WebServiceDefinition)new XmlSerializer(typeof(WebServiceDefinition)).Deserialize(stream);
		}

		public async Task<T> Request<T>(object value)
		{
			using MemoryStream buffer = new MemoryStream();
			using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, EmptyUri)
			{
				Content = new StreamContent(buffer)
			};

			await Serializer.Serialize(buffer, value);
			buffer.Seek(0, SeekOrigin.Begin);

			using HttpResponseMessage response = await HttpClient.SendAsync(request);
			using Stream stream = await response.Content.ReadAsStreamAsync();
			return await Serializer.Deserialize<T>(stream);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!DisposedValue)
			{
				if (disposing)
				{
					HttpClient.Dispose();
				}

				DisposedValue = true;
			}
		}

		public void Dispose() => Dispose(true);
		
	}

}
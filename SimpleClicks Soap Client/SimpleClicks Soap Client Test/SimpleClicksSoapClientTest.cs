using NUnit.Framework;
using SimpleClicks;
using SimpleClicks.Model;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SimpleClicks_Soap_Client_Test
{

	public class SimpleClicksSoapClientTest
	{

		private string ServiceUri, Username, Password;

		[SetUp]
		public void Setup()
		{
			string[] data = File.ReadAllText("ConfigData.txt", Encoding.UTF8).Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
			ServiceUri = data[0];
			Username = data[1];
			Password = data[2];
		}

		[Test]
		public async Task ClientConnectionTest()
		{
			using SimpleClicksSoapClient client = await new SimpleClicksSoapClient(
				new Uri(ServiceUri), new NetworkCredential(Username, Password)).Configure();
			TestContext.WriteLine($"TargetNamespace: {client.ServiceDefinition.TargetNamespace}");
			TestContext.WriteLine($"Messages: {string.Join("\r\n", client.ServiceDefinition.Messages)}");
			Assert.Pass();
		}

		[Test]
		public async Task GetClientTest()
		{
			using SimpleClicksSoapClient client = await new SimpleClicksSoapClient(
				new Uri(ServiceUri), new NetworkCredential(Username, Password)).Configure();

			GetClientResponse getClient = await client.Request<GetClientResponse>(new GetClientRequest());
			TestContext.WriteLine(JsonSerializer.Serialize(getClient, new JsonSerializerOptions() { WriteIndented = true }));
			Assert.IsNotNull(getClient);
		}

		[Test]
		public async Task GetAgentsTest()
		{
			using SimpleClicksSoapClient client = await new SimpleClicksSoapClient(
				new Uri(ServiceUri), new NetworkCredential(Username, Password)).Configure();

			GetAgentsResponse getAgents = await client.Request<GetAgentsResponse>(new GetAgentsRequest());
			TestContext.WriteLine(JsonSerializer.Serialize(getAgents, new JsonSerializerOptions() { WriteIndented = true }));
			Assert.IsNotNull(getAgents);
		}

		[Test]
		public async Task GetAgentTest()
		{
			using SimpleClicksSoapClient client = await new SimpleClicksSoapClient(
				new Uri(ServiceUri), new NetworkCredential(Username, Password)).Configure();

			GetAgentsResponse getAgents = await client.Request<GetAgentsResponse>(new GetAgentsRequest());
			GetAgentResponse getAgent = await client.Request<GetAgentResponse>(new GetAgentRequest(getAgents.Agents[0].AgentId));
			TestContext.WriteLine(JsonSerializer.Serialize(getAgent, new JsonSerializerOptions() { WriteIndented = true }));
			Assert.IsNotNull(getAgents);
		}

		[Test]
		public async Task GetDevicesTest()
		{
			using SimpleClicksSoapClient client = await new SimpleClicksSoapClient(
				new Uri(ServiceUri), new NetworkCredential(Username, Password)).Configure();

			GetAgentsResponse getAgents = await client.Request<GetAgentsResponse>(new GetAgentsRequest());
			GetDevicesResponse getDevices = await client.Request<GetDevicesResponse>(new GetDevicesRequest(getAgents.Agents[0].AgentId));
			TestContext.WriteLine(JsonSerializer.Serialize(getDevices, new JsonSerializerOptions() { WriteIndented = true }));
			Assert.IsNotNull(getDevices);
		}

		[Test]
		public async Task GetCountersTest()
		{
			using SimpleClicksSoapClient client = await new SimpleClicksSoapClient(
				new Uri(ServiceUri), new NetworkCredential(Username, Password)).Configure();

			GetAgentsResponse getAgents = await client.Request<GetAgentsResponse>(new GetAgentsRequest());
			GetDevicesResponse getDevices = await client.Request<GetDevicesResponse>(new GetDevicesRequest(getAgents.Agents[0].AgentId));

			XDocument xml = await client.Request(new GetCountersRequest(getAgents.Agents[0].AgentId, getDevices.Devices[0].DeviceId));
			TestContext.WriteLine(xml);

			Assert.IsNotNull(getAgents);
		}

	}

}
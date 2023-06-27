﻿using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PusherServer;

namespace ClinicDotNet.RealTimeProcessLayer.Services
{
	public class PusherServices : Pusher
	{
		public PusherServices(IConfiguration configuration) : base(configuration["Pusher:AppId"], configuration["Pusher:Key"], configuration["Pusher:Secret"], new PusherOptions
		{
			Cluster = configuration["Pusher:Cluster"],
			Encrypted = true
		})
		{
		}

		public delegate void CallBack(ITriggerResult result);

		public async Task PushToAsync(string[] channels, string actionName, object data, CallBack callBack = null)
		{
			string json_data = JsonConvert.SerializeObject(data, settings: new JsonSerializerSettings()
			{
				ContractResolver = new DefaultContractResolver()
				{
					NamingStrategy = new CamelCaseNamingStrategy()
				},
				Formatting = Formatting.Indented
			});

			ITriggerResult result = await TriggerAsync(channels, actionName, json_data);
			if (callBack != null) callBack(result);
		}
	}
}

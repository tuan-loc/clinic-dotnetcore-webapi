using ClinicDotNet.SegementationXRayServices.Requests;
using ClinicDotNet.SegementationXRayServices.Responses;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;

namespace ClinicDotNet.SegementationXRayServices
{
	public class XrayClient
	{
		private const string LocalBaseUrl = "http://127.0.0.1:8000/api";
		private RestClient _client;

		public XrayClient()
		{
			_client = new RestClient(LocalBaseUrl);
		}

		public XrayClient(string baseUrl)
		{
			_client = new RestClient(baseUrl);
		}

		public XrayClient(IConfiguration configuration) : this(configuration["MechineLearningServer:BaseUrl"])
		{

		}

		public async Task<SegmentationResponseData> UploadFileAsync(PredictionRequest data)
		{
			var request = new RestRequest("/predict/", Method.Post);
			request.AddFile("input_image", data.ImageInputData, data.FileName);
			request.AddParameter("purpose", data.Purpose, ParameterType.RequestBody);
			RestResponse response = await _client.ExecuteAsync(request);

			if(response.StatusCode == System.Net.HttpStatusCode.Created)
			{
				string content = response.Content;
				SegmentationResponseData responseSuccessData = JsonConvert.DeserializeObject<SegmentationResponseData>(content);
				return responseSuccessData;
			}

			throw new Exception("Mechine learning API cannot complete this operation!");
		}
	}
}
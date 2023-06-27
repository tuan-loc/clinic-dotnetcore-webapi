using Newtonsoft.Json;

namespace ClinicDotNet.SegementationXRayServices.Responses
{
	public class ImageResult
	{
		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("image")]
		public string Image { get; set; }
	}
}

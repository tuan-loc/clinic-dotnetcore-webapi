using Newtonsoft.Json;

namespace ClinicDotNet.SegementationXRayServices.Responses
{
	public class PredictionResult
	{
		[JsonProperty("image_result_set")]
		public List<ImageResult> ImageResultSet { get; set; }

		[JsonProperty("teeth_count")]
		public int TeethCount { get; set; }
	}
}

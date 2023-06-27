using System.ComponentModel.DataAnnotations;

namespace ClinicDotNet.DAL.Domain
{
	public class SegmentationResult
	{
		[Key]
		public int Id { get; set; }
		public Appointment Appointment { get; set; }
		public BaseUser Technican { get; set; }
		public string InputImageUrl { get; set; }
		public string ModelName { get; set; }
		public int TeethCount { get; set; }
		public List<SegmentationImageResult> ImageResultSet { get; set; }

		public class SegmentationImageResult
		{
			[Key]
			public int Id { get; set; }
			public string Title { get; set; }
			public string ImageUrl { get; set; }
		}
	}
}

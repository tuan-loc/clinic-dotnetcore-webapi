using System.ComponentModel.DataAnnotations;

namespace ClinicDotNet.DAL.Domain
{
	public class FeedBack : BaseEntity
	{
		[Key]
		public int Id { get; set; }
		public BaseUser BaseUser { get; set; }
		public int ServiceId { get; set; }
		public int AppointmentId { get; set; }
		public float RatingPoint { get; set; }
		public string Content { get; set; }
	}
}

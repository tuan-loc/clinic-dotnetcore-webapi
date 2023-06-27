using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicDotNet.DAL.Domain
{
	public class Document : BaseEntity
	{
		public int Id { get; set; }


		[ForeignKey(nameof(Appointment))]
		public int AppointmentId { get; set; }
		public string Title { get; set; }
		public FileMedia File { get; set; }
		public DocumentTags Tag { get; set; }
	}

	public enum DocumentTags
	{
		Patient,
		Doctor,
	}
}

using ClinicDotNet.DAL.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace ClinicDotNet.DAL.Domain
{
	public class Appointment : BaseEntity
	{
		[Key]
		public int Id { get; set; }

		[ForeignKey(nameof(Doctor))]
		public string DoctorId { get; set; }
		public Doctor Doctor { get; set; }

		[ForeignKey(nameof(Patient))]
		public string PatientId { get; set; }
		public Patient Patient { get; set; }

		[ForeignKey(nameof(Room))]
		public int RoomId { get; set; }
		public Room Room { get; set; }

		[ForeignKey(nameof(Service))]
		public int ServiceId { get; set; }
		public Service Service { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime Date { get; set; }

		[Required]
		public TimeManager.SlotManager Slot { get; set; }

		[Required]
		public string Content { get; set; }
		public States State { get; set; } = States.NotYet;

		public ICollection<Document> Documents { get; set; } = new HashSet<Document>();
		public List<SegmentationResult> SegmentationResults { get; set; } = new List<SegmentationResult>();
	}

	public enum States
	{
		NotYet,
		Accept,
		Cancel,
		Doing,
		Transfer,
		TransferCancel,
		TransferDoing,
		TransferComplete,
		Complete,
	}
}

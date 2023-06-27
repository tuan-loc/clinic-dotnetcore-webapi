using System.ComponentModel.DataAnnotations;

namespace ClinicDotNet.DAL.Domain
{
	public class Contact : BaseEntity
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(32)]
		public string Name { get; set; }

		[Required]
		[DataType(DataType.PhoneNumber)]
		public string PhoneNumber { get; set; }

		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required]
		[StringLength(500)]
		public string Content { get; set; }

		public ContactStates States { get; set; } = ContactStates.Pending;
		public DateTime? FinishedTime { get; set; }
	}

	public enum ContactStates
	{
		Pending,
		Done,
		Ignore
	}
}

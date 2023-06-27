using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicDotNet.DAL.Domain
{
	[Table("Patients")]
	public class Patient : BaseEntity
	{
		[Key]
		[ForeignKey("BaseUser")]
		public string Id { get; set; }
		public BaseUser BaseUser { get; set; }

		[ForeignKey("FileId")]
		public FileMedia MedicalRecordFile { get; set; }

		[ForeignKey("MediaFile")]
		public int FileId { get; set; }
	}
}

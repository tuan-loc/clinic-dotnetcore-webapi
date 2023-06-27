using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicDotNet.DAL.Domain
{
	[Table("Files")]
	public class FileMedia : BaseEntity
	{
		[Key]
		public int Id { get; set; }
		public string FilePath { get; set; }
		public FileCategory Category { get; set; }
	}

	public enum FileCategory
	{
		MedicalRecord,
		DoctorCertificate,
		AppointmentDocument,
	}
}

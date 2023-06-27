using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicDotNet.DAL.Domain
{
	public class Doctor : BaseEntity
	{
		[Key]
		[ForeignKey("BaseUser")]
		public string Id { get; set; }
		public BaseUser BaseUser { get; set; }
		public string Major { get; set; } = "Unknown";
		public FileMedia Certificate { get; set; }
		public bool Verified { get; set; }
	}
}

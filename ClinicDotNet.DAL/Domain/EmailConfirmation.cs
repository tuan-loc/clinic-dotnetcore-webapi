using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicDotNet.DAL.Domain
{
	public class EmailConfirmation : BaseEntity
	{
		[Key]
		[ForeignKey(nameof(BaseUser))]
		public string UserId { get; set; }
		public string LastRequiredCode { get; set; }
		public DateTime ValidTo { get; set; }
	}
}

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ClinicDotNet.DAL.Domain
{
	public class BaseUser : IdentityUser
	{
		[Required]
		public string FullName { get; set; } = "Undefined";
		public string ImageUrl { get; set; } = "https://i.pinimg.com/564x/c6/e5/65/c6e56503cfdd87da299f72dc416023d4.jpg";
		public string ImageAvatarId { get; set; }

		[DataType(DataType.Date)]
		public DateTime BirthDate { get; set; } = DateTime.Now.Date;
		public string Gender { get; set; }
		public string Address { get; set; }
		public UserType Type { get; set; } = UserType.Patient;
		public string PusherChannel { get; set; }
		public EmailConfirmation EmailConfirmation { get; set; }
		public List<UserLock> UserLocks { get; set; }
	}

	public enum UserType
	{
		Patient,
		Doctor,
		Receptionist,
		Technician,
		Expert,
		Administration,
	}
}

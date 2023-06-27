using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicDotNet.DAL.Domain
{
	public class Room : BaseEntity
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string RoomCode { get; set; }
		public string Description { get; set; }
		public ICollection<Device> Devices { get; set; }
		public RoomTypes RoomType { get; set; } = RoomTypes.Active;
		public RoomCategory RoomCategory { get; set; }
	}

	public enum RoomTypes
	{
		Active,
		InActive
	}

	public class RoomCategory
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
	}
}

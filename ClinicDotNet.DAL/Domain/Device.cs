﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicDotNet.DAL.Domain
{
	public class Device : BaseEntity
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		public int DeviceValue { get; set; }

		[Required]
		public string DeviceName { get; set; }

		[Required]
		public string Description { get; set; }
		public string ImageUrl { get; set; }
		public string ImageId { get; set; }

		[Required]
		public DateTime Date { get; set; }
		public bool Status { get; set; } = true;
		public ICollection<Service> Services { get; set; }

		[ForeignKey("Room")]
		public int RoomId { get; set; }
		public Room Room { get; set; }
	}
}


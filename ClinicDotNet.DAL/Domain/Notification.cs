﻿using System.ComponentModel.DataAnnotations;

namespace ClinicDotNet.DAL.Domain
{
	public class Notification : BaseEntity
	{
		[Key]
		public int Id { get; set; }

		public BaseUser Receiver { get; set; }
		public string Content { get; set; }
		public bool Clicked { get; set; }
		public string Url { get; set; }
		public bool Hidden { get; set; }
		public NotificationCategories Category { get; set; }
	}

	public enum NotificationCategories
	{
		Success,
		Failed,
	}
}

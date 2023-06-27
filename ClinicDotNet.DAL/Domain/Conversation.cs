using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicDotNet.DAL.Domain
{
	public class Conversation
	{
		[Key]
		public int Id { get; set; }

		[ForeignKey(nameof(BaseUser))]
		public string UserId { get; set; }
		public BaseUser User { get; set; }

		public bool HasMessageUnRead { get; set; }

		[ForeignKey(nameof(Message))]
		public int LastMessageId { get; set; }

		[ForeignKey(nameof(LastMessageId))]
		public Message LastMessage { get; set; }
	}
}

namespace ClinicDotNet.DAL.Domain
{
	public class Post : BaseEntity
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public BaseUser Creator { get; set; }
		public DateTime PublishDate { get; set; }
		public List<Service> Services { get; set; }
	}
}

namespace ClinicDotNet.DAL.Domain
{
	public abstract class BaseEntity
	{
		public DateTime? TimeCreated { get; set; } = DateTime.Now;
		public DateTime? LastTimeModified { get; set; }
	}
}

using ClinicDotNet.DAL.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClinicDotNet.DAL.DataContexts
{
	public class AppDbContext : IdentityDbContext<BaseUser>
	{
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<FileMedia> FileMedias { get; set; }
		public DbSet<Patient> Patients { get; set; }
		public DbSet<Room> Rooms { get; set; }
		public DbSet<RoomCategory> RoomCategories { get; set; }
		public DbSet<Device> Devices { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Appointment> Appointments { get; set; }
		public DbSet<Document> Documents { get; set; }
		public DbSet<Message> ChatMessages { get; set; }
		public DbSet<Conversation> Conversations { get; set; }
		public DbSet<EmailConfirmation> EmailConfirmations { get; set; }
		public DbSet<UserLock> UserLocks { get; set; }
		public DbSet<Notification> Notifications { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<FeedBack> FeedBacks { get; set; }
		public DbSet<SegmentationResult> SegmentationResults { get; set; }

		public override int SaveChanges()
		{
			var entryEntities = ChangeTracker.Entries<BaseEntity>();
			foreach (var entry in entryEntities)
			{
				if(entry.State == EntityState.Modified)
				{
					entry.Entity.LastTimeModified = DateTime.Now;
				}
			}

			return base.SaveChanges();
		}
	}
}
